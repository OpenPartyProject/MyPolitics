using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyPolitics.CongressApi.Legislators
{
    public class Legislator
    {
        /// <summary>
        /// Identifier for this member in various Congressional sources. Originally taken from the Congressional Biographical Directory, but used in many places. If you’re going to pick one ID as a Congressperson’s unique ID, use this.
        /// </summary>
        [JsonProperty("bioguide_id")]
        public string BioGuideId { get; set; }
        /// <summary>
        /// The date of this legislator’s birthday.
        /// </summary>
        [JsonProperty("birthday")]
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// Chamber the member is in. “senate” or “house”.
        /// </summary>
        [JsonProperty("chamber")]
        public string Chamber { get; set; }
        /// <summary>
        /// URL to their official contact form.
        /// </summary>
        [JsonProperty("contact_form")]
        public string ContactForm { get; set; }
        /// <summary>
        /// Identifier for this member as it appears on CRP’s OpenSecrets.
        /// </summary>
        [JsonProperty("crp_id")]
        public string CrpId { get; set; }
        /// <summary>
        /// (House only) The number of the district that a House member represents.
        /// </summary>
        [JsonProperty("district")]
        public int? District { get; set; }
        /// <summary>
        /// The Facebook username or ID for a member’s official legislative Facebook presence. ID numbers and usernames can be used interchangeably in Facebook’s URLs and APIs. The referenced account may be either a Facebook page or a user account.
        /// </summary>
        [JsonProperty("facebook_id")]
        public long FacebookId { get; set; }
        /// <summary>
        /// Fax number of the member’s DC office.
        /// </summary>
        [JsonProperty("fax")]
        public string Fax { get; set; }
        /// <summary>
        /// A list of identifiers for this member as they appear in filings at the Federal Election Commission.
        /// </summary>
        [JsonProperty("fec_ids")]
        public string[] FecIds { get; set; }
        /// <summary>
        /// The member’s first name. This may or may not be the name they are usually called.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// First letter of this member’s gender. “M” or “F”.
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }
        /// <summary>
        /// Identifier for this member as it appears on GovTrack.us.
        /// </summary>
        [JsonProperty("govtrack_id")]
        public int GovTrackId { get; set; }
        /// <summary>
        /// Identifier for this member as it is maintained by the Inter-university Consortium for Political and Social Research.
        /// </summary>
        [JsonProperty("icpsr_id")]
        public int InteruniversityConsortiumForPoliticalAndSocialResearchId { get; set; }
        /// <summary>
        /// Whether a legislator is currently holding elected office in Congress.
        /// </summary>
        [JsonProperty("in_office")]
        public bool InOffice { get; set; }
        /// <summary>
        /// An array of common names combinations for a Congressperson if a combination does not exist, the result will be null and the index will be consistent.
        /// </summary>
        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }
        /// <summary>
        /// The member’s last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// The member’s middle name, if they have one.
        /// </summary>
        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }
        /// <summary>
        /// A name suffix, if the member uses one. For example, “Jr.” or “III”.
        /// </summary>
        [JsonProperty("name_suffix")]
        public string NameSuffix { get; set; }
        /// <summary>
        /// The member’s nickname. If present, usually safe to assume this is the name they go by.
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        [JsonProperty("oc_email")]
        public string OpenCongressEmail { get; set; }
        /// <summary>
        /// (Senate only) The seniority of that Senator for that state. “junior” or “senior”.
        /// </summary>
        [JsonProperty("senate_rank")]
        public string StateRank { get; set; }
        /// <summary>
        /// Which senate “class” the member belongs to (1, 2, or 3). Every 2 years, a separate one third of the Senate is elected to a 6-year term. Senators of the same class face election in the same year. Blank for members of the House.
        /// </summary>
        [JsonProperty("senate_class")]
        public string SenateClass { get; set; }
        /// <summary>
        /// Identifier for this member across all countries and levels of government, as defined by the Open Civic Data project.
        /// </summary>
        [JsonProperty("ocd_id")]
        public string OpenCivicDataId { get; set; }
        /// <summary>
        /// Office number for the member’s DC office.
        /// </summary>
        [JsonProperty("office")]
        public string Office { get; set; }
        /// <summary>
        /// First letter of the party this member belongs to. “R”, “D”, or “I”.
        /// </summary>
        [JsonProperty("party")]
        public string Party { get; set; }
        /// <summary>
        /// Phone number of the member’s DC office.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
        /// <summary>
        /// Two-letter code of the state this member represents.
        /// </summary>
        [JsonProperty("state")]
        public string StateAbbreviation { get; set; }
        /// <summary>
        /// The full state name of the state this member represents.
        /// </summary>
        [JsonProperty("state_name")]
        public string StateName { get; set; }
        /// <summary>
        /// The date a member’s current term will end.
        /// </summary>
        [JsonProperty("term_end")]
        public DateTime TermEnd { get; set; }
        /// <summary>
        /// The date a member’s current term started.
        /// </summary>
        [JsonProperty("term_start")]
        public DateTime TermStart { get; set; }
        /// <summary>
        /// Identifier for this member as it appears on some of Congress’ data systems (namely Senate votes).
        /// </summary>
        [JsonProperty("lis_id")]
        public string LisId { get; set; }
        /// <summary>
        /// Identifier for this member as it appears on THOMAS.gov and Congress.gov.
        /// </summary>
        [JsonProperty("thomas_id")]
        public string ThomasId { get; set; }
        /// <summary>
        /// Title of this member. “Sen”, “Rep”, “Del”, or “Com”.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// This is the official government account of a member of Congress. This data comes from the @unitedstates project.
        /// </summary>
        [JsonProperty("twitter_id")]
        public string TwitterId { get; set; }
        /// <summary>
        /// This is an array of twitter accounts of a congressperson’s campaign. This comes from Sunlight’s Politwoops project. If you think you have uncovered a new account, email us at twoops@sunlightfoundation.com.
        /// </summary>
        [JsonProperty("campaign_twitter_ids")]
        public string[] CampaignTwitterIds { get; set; }
        /// <summary>
        /// Identifier for this member as it appears on Project Vote Smart.
        /// </summary>
        [JsonProperty("votesmart_id")]
        public int VoteSmartId { get; set; }
        /// <summary>
        /// Official legislative website.
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; }
        /// <summary>
        /// The YouTube username or channel for a member’s official legislative account. This field does not contain the handles of campaign accounts. A few legislators use YouTube “channels” instead of regular accounts. These channels will be of the form channel/[id].
        /// </summary>
        [JsonProperty("youtube_id")]
        public string YouTubeId { get; set; }
    }
}