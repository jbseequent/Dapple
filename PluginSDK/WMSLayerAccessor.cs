using System;
using System.Collections.Generic;
using System.Globalization;
using Utility;
using WorldWind.Renderable;

namespace WorldWind.Net.Wms
{
	/// <summary>
	/// Calculates URLs for WMS layers.
	/// </summary>
	public class WmsImageStoreDapple : ImageStore
	{
		#region Private Members

		string m_serverGetMapUrl;
		string m_wmsLayerName;
		string m_wmsLayerStyle;
		string m_imageFormat;
		string m_version;
		string m_srs;
		string m_crs;
		int m_textureSizePixels = 512;
		TimeSpan m_cacheExpirationTime = TimeSpan.MaxValue;

		#endregion

		public WmsImageStoreDapple(string imageFormat, string serverGetMapUrl, string version, string layerName, string wmsLayerStyle, string srs, string crs)
		{
			m_imageFormat = imageFormat;
			m_serverGetMapUrl = serverGetMapUrl;
			m_version = version;
			m_wmsLayerName = layerName;
			m_wmsLayerStyle = wmsLayerStyle;
			m_srs = srs;
			m_crs = crs;
		}


		#region ImageStore Overrides

		public override bool IsDownloadableLayer
		{
			get
			{
				return true;
			}
		}

		protected override string GetDownloadUrl(IGeoSpatialDownloadTile tile)
		{

			string projectionRequest = "";

			if (m_version == "1.1.1")
			{
				if (GCSMappings.WMSWGS84Equivalents.Contains(m_srs))
					projectionRequest = "srs=" + m_srs;
				else
					projectionRequest = "srs=EPSG:4326";
			}
			else
			{
				if (GCSMappings.WMSWGS84Equivalents.Contains(m_crs))
					projectionRequest = "crs=" + m_crs;
				else
					projectionRequest = "crs=CRS:84";
			}

			string wmsQuery = string.Format(
			   CultureInfo.InvariantCulture,
			   "{0}" + (m_serverGetMapUrl.IndexOf("?") == -1 ? "?" : "") +
			   "service=WMS&version={1}&request=GetMap&layers={2}&format={3}&width={4}&height={5}&{6}&bbox={7},{8},{9},{10}&styles={11}",
			   m_serverGetMapUrl,
			   m_version,
			   m_wmsLayerName,
			   m_imageFormat,
			   m_textureSizePixels,
			   m_textureSizePixels,
			   projectionRequest,
			   tile.West, tile.South, tile.East, tile.North,
			   m_wmsLayerStyle);

			// Cleanup
			while (wmsQuery.IndexOf("??") != -1)
				wmsQuery = wmsQuery.Replace("??", "?");

			return wmsQuery;
		}
		#endregion

		#region Properties

		public virtual TimeSpan CacheExpirationTime
		{
			get
			{
				return m_cacheExpirationTime;
			}
			set
			{
				m_cacheExpirationTime = value;
			}
		}

		public virtual string ServerGetMapUrl
		{
			get
			{
				return m_serverGetMapUrl;
			}
			set
			{
				m_serverGetMapUrl = value;
			}
		}

		public virtual string SRS
		{
			get
			{
				return m_srs;
			}
			set
			{
				m_srs = value;
			}
		}

		public virtual string CRS
		{
			get
			{
				return m_crs;
			}
			set
			{
				m_crs = value;
			}
		}


		public virtual string WMSLayerName
		{
			get
			{
				return m_wmsLayerName;
			}
			set
			{
				m_wmsLayerName = value;
			}
		}

		public virtual string WMSLayerStyle
		{
			get
			{
				return m_wmsLayerStyle;
			}
			set
			{
				m_wmsLayerStyle = value;
			}
		}

		public virtual string ImageFormat
		{
			get
			{
				return m_imageFormat;
			}
			set
			{
				m_imageFormat = value;
			}
		}

		public virtual string Version
		{
			get
			{
				return m_version;
			}
			set
			{
				m_version = value;
			}
		}

		/// <summary>
		/// Bitmap width/height
		/// </summary>
		public override int TextureSizePixels
		{
			get
			{
				return m_textureSizePixels;
			}
			set
			{
				m_textureSizePixels = value;
			}
		}
		#endregion
	}
	/// <summary>
	/// Calculates URLs for WMS layers.
	/// </summary>
	public class WmsImageStore : ImageStore
	{
		#region Private Members

		string m_serverGetMapUrl;
		string m_wmsLayerName;
		string m_wmsLayerStyle;
		string m_imageFormat;
		string m_version;
		int m_textureSizePixels = 512;

		#endregion

		#region Properties

		public override bool IsDownloadableLayer
		{
			get
			{
				return true;
			}
		}

		public virtual string ServerGetMapUrl
		{
			get
			{
				return m_serverGetMapUrl;
			}
			set
			{
				m_serverGetMapUrl = value;
			}
		}

		public virtual string WMSLayerName
		{
			get
			{
				return m_wmsLayerName;
			}
			set
			{
				m_wmsLayerName = value;
			}
		}

		public virtual string WMSLayerStyle
		{
			get
			{
				return m_wmsLayerStyle;
			}
			set
			{
				m_wmsLayerStyle = value;
			}
		}

		public virtual string ImageFormat
		{
			get
			{
				return m_imageFormat;
			}
			set
			{
				m_imageFormat = value;
			}
		}

		public virtual string Version
		{
			get
			{
				return m_version;
			}
			set
			{
				m_version = value;
			}
		}

		/// <summary>
		/// Bitmap width/height
		/// </summary>
		public override int TextureSizePixels
		{
			get
			{
				return m_textureSizePixels;
			}
			set
			{
				m_textureSizePixels = value;
			}
		}


		#endregion

		#region Public Methods

		protected override string GetDownloadUrl(IGeoSpatialDownloadTile tile)
		{
			if (m_serverGetMapUrl.IndexOf('?') >= 0)
			{
				// Allow custom format string url
				// http://server.net/path?imageformat=png&width={WIDTH}&north={NORTH}...
				string url = m_serverGetMapUrl;
				url = url.Replace("{WIDTH}", m_textureSizePixels.ToString(CultureInfo.InvariantCulture));
				url = url.Replace("{HEIGHT}", m_textureSizePixels.ToString(CultureInfo.InvariantCulture));
				url = url.Replace("{WEST}", tile.West.ToString(CultureInfo.InvariantCulture));
				url = url.Replace("{EAST}", tile.East.ToString(CultureInfo.InvariantCulture));
				url = url.Replace("{NORTH}", tile.North.ToString(CultureInfo.InvariantCulture));
				url = url.Replace("{SOUTH}", tile.South.ToString(CultureInfo.InvariantCulture));

				return url;
			}
			else
			{
				string url = string.Format(CultureInfo.InvariantCulture,
					"{0}?request=GetMap&layers={1}&srs=EPSG:4326&width={2}&height={3}&bbox={4},{5},{6},{7}&format={8}&version={9}&styles={10}",
					m_serverGetMapUrl,
					m_wmsLayerName,
					m_textureSizePixels,
					m_textureSizePixels,
					tile.West, tile.South, tile.East, tile.North,
					m_imageFormat,
					m_version,
					m_wmsLayerStyle);

				return url;
			}
		}

		#endregion
	}
}
