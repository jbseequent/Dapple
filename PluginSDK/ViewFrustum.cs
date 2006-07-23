using System;

namespace WorldWind
{
	/// <summary>
	/// The region of space in the modeled world that may appear on the screen; it is the field of view of the notional camera.
	/// Used to perform culling of invisible object (prior to rendering) to increase speed.
	/// See: http://en.wikipedia.org/wiki/Viewing_frustum
	/// </summary>
	public class Frustum
	{
		public Plane2d[] planes = new Plane2d[6];

		public void Update(Matrix4d m)
		{
			//bottom (down) plane
			this.planes[0] = new Plane2d(
				m[0, 3] + m[0, 1],
				m[1, 3] + m[1, 1],
				m[2, 3] + m[2, 1],
				m[3, 3] + m[3, 1]
				);
			
			//far plane
			this.planes[1] = new Plane2d(
				m[0, 3] - m[0, 2],
				m[1, 3] - m[1, 2],
				m[2, 3] - m[2, 2],
				m[3, 3] - m[3, 2]
				);

			//right side plane
			this.planes[2] = new Plane2d(
				m[0, 3] - m[0, 0],
				m[1, 3] - m[1, 0],
				m[2, 3] - m[2, 0],
				m[3, 3] - m[3, 0]
				);

			//left side plane
			this.planes[3] = new Plane2d(
				m[0, 3] + m[0, 0],
				m[1, 3] + m[1, 0],
				m[2, 3] + m[2, 0],
				m[3, 3] + m[3, 0]
				);

			//near plane
			this.planes[4] = new Plane2d(
				m[0, 2],
				m[1, 2],
				m[2, 2],
				m[3, 2]);

			//top (up) plane
			this.planes[5] = new Plane2d(
				m[0, 3] - m[0, 1],
				m[1, 3] - m[1, 1],
				m[2, 3] - m[2, 1],
				m[3, 3] - m[3, 1]
				);

			foreach(Plane2d p in this.planes)
				p.Normalize();
		}

		/// <summary>
		/// Test if a sphere intersects or is completely inside the frustum.
		/// </summary>
		/// <returns>true when the sphere intersects.</returns>
		public bool Intersects(BoundingSphere c)
		{
			foreach(Plane2d p in this.planes)
			{
				double distancePlaneToPoint = p.A * c.Center.X + p.B * c.Center.Y + p.C * c.Center.Z + p.D;
            if (distancePlaneToPoint * distancePlaneToPoint < -c.RadiusSq)
					// More than 1 radius outside the plane = outside
					return false;
			}

			//else it's in view
			return true;
		}

      /// <summary>
      /// Test if a sphere intersects at least one plane in in the frustum.
      /// </summary>
      /// <returns>true when the sphere intersects.</returns>
      public bool IntersectsOne(BoundingSphere c)
      {
         foreach (Plane2d p in this.planes)
         {
            double distancePlaneToPoint = p.A * c.Center.X + p.B * c.Center.Y + p.C * c.Center.Z + p.D;
            if (distancePlaneToPoint * distancePlaneToPoint > -c.RadiusSq)
               // 1 radius inside the plane = outside
               return true;
         }

         //else it's in view
         return false;
      }


		/// <summary>
		/// Test if a point is inside the frustum.
		/// </summary>
		/// <returns>true when the point is inside.</returns>
		/// <param name="v">XYZ in world coordinates of the point to test.</param>
		public bool ContainsPoint(Vector3d v)
		{
			foreach(Plane2d p in this.planes)
				if(Vector3d.dot(new Vector3d(p.A, p.B, p.C), v) + p.D < 0)
					return false;

			return true;
		}

		/// <summary>
		/// Tests if the view frustum fully contains the bounding box.
		/// </summary>
		/// <returns>true when the box is complete enclosed by the frustum.</returns>
		public bool Contains(BoundingBox bb)
		{
         // Optimize by always checking bounding sphere first
         if (!Intersects(bb.boundsphere))
            return false;

			//Code taken from Flip Code Article:
			// http://www.flipcode.com/articles/article_frustumculling.shtml
			int iTotalIn = 0;
			foreach(Plane2d p in this.planes)
			{
				int iInCount = 8;
				int iPtIn = 1;
				for(int i = 0; i < 8; i++)
				{
					if(Vector3d.dot(new Vector3d(p.A,p.B,p.C), bb.corners[i]) + p.D < 0)
					{
						iPtIn = 0;
						--iInCount;
					}
				}

				if(iInCount == 0)
					return false;

				iTotalIn += iPtIn;
			}

			if(iTotalIn == 6)
				return true;

			return false;
		}

		/// <summary>
		/// Tests if the bounding box specified intersects with or is fully contained in the frustum.
		/// </summary>
		/// <returns>true when the box intersects with the frustum.</returns>
		public bool Intersects(BoundingBox bb)
		{
         Vector3d v;

         // Optimize by always checking bounding sphere first
         if (!IntersectsOne(bb.boundsphere))
            return false;

         foreach (Plane2d p in this.planes)
			{
				v.X = p.A;
            v.Y = p.B;
            v.Z = p.C;
				bool isInside = false;
				for(int i = 0; i < 8; i++)
				{
					if(Vector3d.dot(v, bb.corners[i]) + p.D >= 0)
					{
						isInside = true;
						break;
					}
				}

				if(!isInside)
					return false;
			}

			return true;
		}
	
		public override string ToString()
		{
         return string.Format("Near(4):\n{0}\nFar(1):\n{1}\n", planes[4], planes[1]) +
                string.Format("Other(0,2,3,5):\n{0}\n{1}\n{2}\n{3}\n", planes[0], planes[2], planes[3], planes[5]);
		}
	}
}
