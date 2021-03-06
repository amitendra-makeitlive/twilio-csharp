/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Insights.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchRoomOptions
    /// </summary>
    public class FetchRoomOptions : IOptions<RoomResource>
    {
        /// <summary>
        /// The room_sid
        /// </summary>
        public string PathRoomSid { get; }

        /// <summary>
        /// Construct a new FetchRoomOptions
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        public FetchRoomOptions(string pathRoomSid)
        {
            PathRoomSid = pathRoomSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadRoomOptions
    /// </summary>
    public class ReadRoomOptions : ReadOptions<RoomResource>
    {
        /// <summary>
        /// The room_type
        /// </summary>
        public List<RoomResource.RoomTypeEnum> RoomType { get; set; }
        /// <summary>
        /// The codec
        /// </summary>
        public List<RoomResource.CodecEnum> Codec { get; set; }
        /// <summary>
        /// The room_name
        /// </summary>
        public string RoomName { get; set; }
        /// <summary>
        /// The created_after
        /// </summary>
        public DateTime? CreatedAfter { get; set; }
        /// <summary>
        /// The created_before
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Construct a new ReadRoomOptions
        /// </summary>
        public ReadRoomOptions()
        {
            RoomType = new List<RoomResource.RoomTypeEnum>();
            Codec = new List<RoomResource.CodecEnum>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (RoomType != null)
            {
                p.AddRange(RoomType.Select(prop => new KeyValuePair<string, string>("RoomType", prop.ToString())));
            }

            if (Codec != null)
            {
                p.AddRange(Codec.Select(prop => new KeyValuePair<string, string>("Codec", prop.ToString())));
            }

            if (RoomName != null)
            {
                p.Add(new KeyValuePair<string, string>("RoomName", RoomName));
            }

            if (CreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedAfter", Serializers.DateTimeIso8601(CreatedAfter)));
            }

            if (CreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBefore", Serializers.DateTimeIso8601(CreatedBefore)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}