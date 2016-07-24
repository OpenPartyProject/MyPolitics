using System;

namespace MyPolitics.Sunlight.CongressApi.Legislators
{
    public class LegislatorSearchOptions
    {
        /* todo: add last of search options for legislators to options
         * in_office
Whether a legislator is currently holding elected office in Congress.
* party
First letter of the party this member belongs to. “R”, “D”, or “I”.
* gender
First letter of this member’s gender. “M” or “F”.
* state
Two-letter code of the state this member represents.
* state_name

         */

        public string Query { get; set; }
        /// <summary>
        /// The date a member’s current term started.
        /// </summary>
        public DateTime TermStart { get; set; }
        /// <summary>
        /// The date a member’s current term will end.
        /// </summary>
        public DateTime TermEnd { get; set; }
        /// <summary>
        /// The date of this legislator’s birthday.
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// todo: make senate “class” a value type.
        /// Which senate “class” the member belongs to (1, 2, or 3). Every 2 years, a separate one third of the Senate is elected to a 6-year term. Senators of the same class face election in the same year. Blank for members of the House.
        /// </summary>
        public int SenateClass { get; set; }
        /// <summary>
        /// Chamber the member is in. “senate” or “house”. todo: make chamber a value type.
        /// </summary>
        public string Chamber { get; set; }
        /// <summary>
        /// Title of this member. “Sen”, “Rep”, “Del”, or “Com”.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// (Senate only) The seniority of that Senator for that state. “junior” or “senior”. todo: make StateRank a value type.
        /// </summary>
        public string StateRank { get; set; }
        /// <summary>
        /// (House only) The number of the district that a House member represents.  todo: make District a value type.
        /// </summary>
        public int District { get; set; }
        /// <summary>
        /// The full state name of the state this member represents.
        /// </summary>
        public string StateName { get; set; }
    }
}