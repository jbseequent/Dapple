using System;

namespace WorldWind
{
	/// <summary>
	/// Commonly used mathematical functions.
	/// </summary>
	public sealed class MathEngine
	{
		/// <summary>
		/// This class has only static methods.
		/// </summary>
		private MathEngine()
		{
		}

		/// <summary>
		/// Converts position in spherical coordinates (lat/lon/altitude) to cartesian (XYZ) coordinates.
		/// </summary>
		/// <param name="latitude">Latitude in decimal degrees</param>
		/// <param name="longitude">Longitude in decimal degrees</param>
		/// <param name="radius">Radius (OBS: not altitude)</param>
		/// <returns>Coordinates converted to cartesian (XYZ)</returns>
		public static void SphericalToCartesian(
			double latitude,
			double longitude,
			double radius,
         ref Vector3d v
			)
		{
			latitude *= System.Math.PI / 180.0f;
			longitude *= System.Math.PI /180.0f;

			double radCosLat = radius * Math.Cos(latitude);

			v.X = radCosLat * Math.Cos(longitude);
			v.Y = radCosLat * Math.Sin(longitude);
			v.Z = radius * Math.Sin(latitude);
		}
      public static Vector3d SphericalToCartesian(
         double latitude,
         double longitude,
         double radius
         )
      {
         Vector3d v = Vector3d.Empty;
         SphericalToCartesian(latitude, longitude, radius, ref v);
         return v;   
      }

      /// <summary>
		/// Converts position in spherical coordinates (lat/lon/altitude) to cartesian (XYZ) coordinates.
		/// </summary>
		/// <param name="latitude">Latitude (Angle)</param>
		/// <param name="longitude">Longitude (Angle)</param>
		/// <param name="radius">Radius (OBS: not altitude)</param>
		/// <returns>Coordinates converted to cartesian (XYZ)</returns>
      public static void SphericalToCartesian(
			Angle latitude,
			Angle longitude,
			double radius,
         ref Vector3d v)
		{
			double latRadians = latitude.Radians;
			double lonRadians = longitude.Radians;

			double radCosLat = radius * Math.Cos(latRadians);

			v.X = radCosLat * Math.Cos(lonRadians);
			v.Y = radCosLat * Math.Sin(lonRadians);
			v.Z = radius * Math.Sin(latRadians);
		}
      public static Vector3d SphericalToCartesian(
         Angle latitude,
         Angle longitude,
         double radius)
      {
         Vector3d v = Vector3d.Empty;
         SphericalToCartesian(latitude, longitude, radius, ref v);
         return v;   
      }

		/// <summary>
		/// Converts position in cartesian coordinates (XYZ) to spherical (lat/lon/radius) coordinates in radians.
		/// </summary>
		/// <returns>Coordinates converted to spherical coordinates.  X=radius, Y=latitude (radians), Z=longitude (radians).</returns>
      public static Vector3d CartesianToSpherical(double x, double y, double z)
		{
			double rho = Math.Sqrt((x * x + y * y + z * z));
			double longitude = Math.Atan2(y,x);
			double latitude = (Math.Asin(z / rho));

         return new Vector3d(rho, latitude, longitude);
		}
		
		/// <summary>
		/// Converts an angle in decimal degrees to angle in radians
		/// </summary>
		/// <param name="degrees">Angle in decimal degrees (0-360)</param>
		/// <returns>Angle in radians (0-2*Pi)</returns>
		public static double DegreesToRadians(double degrees)
		{
			return Math.PI * degrees / 180.0f;
		}

		/// <summary>
		/// Converts an angle in radians to angle in decimal degrees 
		/// </summary>
		/// <param name="radians">Angle in radians (0-2*Pi)</param>
		/// <returns>Angle in decimal degrees (0-360)</returns>
		public static double RadiansToDegrees(double radians)
		{
			return  radians * 180.0 / Math.PI;
		}

		/// <summary>
		/// Computes the angle (seen from the center of the sphere) between 2 sets of latitude/longitude values.
		/// </summary>
		/// <param name="latA">Latitude of point 1 (decimal degrees)</param>
		/// <param name="lonA">Longitude of point 1 (decimal degrees)</param>
		/// <param name="latB">Latitude of point 2 (decimal degrees)</param>
		/// <param name="lonB">Longitude of point 2 (decimal degrees)</param>
		/// <returns>Angle in decimal degrees</returns>
		public static double SphericalDistanceDegrees(double latA, double lonA, double latB, double lonB)
		{
         double radLatA = MathEngine.DegreesToRadians(latA);
         double radLatB = MathEngine.DegreesToRadians(latB);
         double radLonA = MathEngine.DegreesToRadians(lonA);
         double radLonB = MathEngine.DegreesToRadians(lonB);

         return MathEngine.RadiansToDegrees(
            Math.Acos(Math.Cos(radLatA) * Math.Cos(radLatB) * Math.Cos(radLonA - radLonB) + Math.Sin(radLatA) * Math.Sin(radLatB)));
      }

      /// <summary>
		/// Computes the angular distance between two pairs of lat/longs.
		/// Fails for distances (on earth) smaller than approx. 2km. (returns 0)
		/// </summary>
		public static Angle SphericalDistance(Angle latA, Angle lonA, Angle latB, Angle lonB)
		{
			double radLatA = latA.Radians;
			double radLatB = latB.Radians;
			double radLonA = lonA.Radians;
			double radLonB = lonB.Radians;

			return Angle.FromRadians( Math.Acos(
				Math.Cos(radLatA)*Math.Cos(radLatB)*Math.Cos(radLonA-radLonB)+
				Math.Sin(radLatA)*Math.Sin(radLatB)) );
		}
		/// Compute the tile number (used in file names) for given latitude and tile size.
		/// </summary>
		/// <param name="latitude">Latitude (decimal degrees)</param>
		/// <param name="tileSize">Tile size  (decimal degrees)</param>
		/// <returns>The tile number</returns>
		public static int GetRowFromLatitude(double latitude, double tileSize)
		{
			return (int)System.Math.Round((System.Math.Abs(-90.0 - latitude)%180)/tileSize, 1);
		}

		/// <summary>
		/// Compute the tile number (used in file names) for given latitude and tile size.
		/// </summary>
		/// <param name="latitude">Latitude (decimal degrees)</param>
		/// <param name="tileSize">Tile size  (decimal degrees)</param>
		/// <returns>The tile number</returns>
		public static int GetRowFromLatitude(Angle latitude, double tileSize)
		{
			return (int)System.Math.Round((System.Math.Abs(-90.0 - latitude.Degrees)%180)/tileSize, 1);
		}

		/// <summary>
		/// Compute the tile number (used in file names) for given longitude and tile size.
		/// </summary>
		/// <param name="longitude">Longitude (decimal degrees)</param>
		/// <param name="tileSize">Tile size  (decimal degrees)</param>
		/// <returns>The tile number</returns>
		public static int GetColFromLongitude(double longitude, double tileSize)
		{
			return (int)System.Math.Round((System.Math.Abs(-180.0 - longitude)%360)/tileSize, 1);
		}

		/// <summary>
		/// Compute the tile number (used in file names) for given longitude and tile size.
		/// </summary>
		/// <param name="longitude">Longitude (decimal degrees)</param>
		/// <param name="tileSize">Tile size  (decimal degrees)</param>
		/// <returns>The tile number</returns>
		public static int GetColFromLongitude(Angle longitude, double tileSize)
		{
			return (int)System.Math.Round((System.Math.Abs(-180.0 - longitude.Degrees)%360)/tileSize, 1);
		}

		/// <summary>
		/// Computes the distance between a point and a plane.
		/// </summary>
		/// <param name="p">Plane</param>
		/// <param name="v">Point (XYZ coordinates)</param>
		/// <returns>The shortest distance between the point and the plane.</returns>
		public static double DistancePlaneToPoint(Plane2d p, Vector3d v)
		{
			return p.A * v.X + p.B * v.Y + p.C + v.Z + p.D;
		}

		/// <summary>
		/// Computes the hypotenuse (sqrt(x�+y�)).
		/// </summary>
		public static double Hypot( double x, double y )
		{
			return Math.Sqrt(x*x + y*y);
		}
	}
}
