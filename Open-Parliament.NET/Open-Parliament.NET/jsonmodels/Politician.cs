using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open_Parliament.NET.jsonmodels
{
    public class Link
    {
        public string url { get; set; }
        public string note { get; set; }
    }

    public class OtherInfo
    {
        public List<string> favourite_word { get; set; }
        public List<string> twitter { get; set; }
        public List<string> twitter_id { get; set; }
        public List<string> parl_id { get; set; }
        public List<string> constituency_offices { get; set; }
        public List<string> alternate_name { get; set; }
    }

    public class Related
    {
        public string speeches_url { get; set; }
        public string ballots_url { get; set; }
        public string sponsored_bills_url { get; set; }
        public string activity_rss_url { get; set; }
    }

    public class Name
    {
        public string en { get; set; }
    }

    public class Riding
    {
        public string province { get; set; }
        public Name name { get; set; }
        public int id { get; set; }
    }

    public class Name2
    {
        public string en { get; set; }
    }

    public class ShortName
    {
        public string en { get; set; }
    }

    public class Party
    {
        public Name2 name { get; set; }
        public ShortName short_name { get; set; }
    }

    public class Label
    {
        public string en { get; set; }
    }

    public class Membership
    {
        public object end_date { get; set; }
        public Riding riding { get; set; }
        public string url { get; set; }
        public Party party { get; set; }
        public string start_date { get; set; }
        public Label label { get; set; }
    }

    public class Politician
    {
        public string fax { get; set; }
        public List<Link> links { get; set; }
        public string image { get; set; }
        public OtherInfo other_info { get; set; }
        public Related related { get; set; }
        public string family_name { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string gender { get; set; }
        public List<Membership> memberships { get; set; }
        public string given_name { get; set; }
        public string voice { get; set; }
        public string email { get; set; }
    }
}
