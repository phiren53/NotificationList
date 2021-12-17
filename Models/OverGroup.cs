using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NotificationList.Models
{
    public class OverGroup
    {
        [DisplayName("RelativityID")]
        public string relativityid { get; set; }

        [DisplayName("CRA Unique ID")]
        public string CRA_UNIQUE_ID { get; set; }

        [DisplayName("CRA Parent Record ID")]
        public string CRA_PARENT_RECORD_ID { get; set; }

        [DisplayName("FirstName")]
        public string FIRSTNAME { get; set; }

        [DisplayName("MiddleName")]
        public string MIDDLENAME { get; set; }

        [DisplayName("LastName")]
        public string LASTNAME { get; set; }

        [DisplayName("SSN")]
        public string SSN { get; set; }

        [DisplayName("Birthdate")]
        public string BIRTHDATE { get; set; }

        [DisplayName("EIN")]
        public string EIN { get; set; }

        [DisplayName("Address")]
        public string CRA_MERGED_ADDRESS { get; set; }

        [DisplayName("Review Flag")]
        public string Review_Flag { get; set; }

        public OverGroup()
        {
            relativityid = "NA";
            CRA_UNIQUE_ID = "NA";
            CRA_PARENT_RECORD_ID = "NA";
            FIRSTNAME = "NA";
            MIDDLENAME = "NA";
            LASTNAME = "NA";
            SSN = "NA";
            BIRTHDATE = "NA";
            EIN = "NA";
            CRA_MERGED_ADDRESS = "NA";
            Review_Flag = "NA";
        }

    }

    public class Entity
    {
        [DisplayName("CRA Parent Record ID")]
        public string PARENT_RECORD { get; set; }

        [DisplayName("Entity")]
        public string ENT { get; set; }

        [DisplayName("SSN")]
        public string SSN { get; set; }

        [DisplayName("Birthdate")]
        public string BIRTHDATE { get; set; }

        [DisplayName("EIN")]
        public string EIN { get; set; }

        [DisplayName("Address")]
        public string MERGED_ADDRESS { get; set; }

        [DisplayName("Review Flag")]
        public string Review_Flag { get; set; }

        public Entity()
        {
            PARENT_RECORD = "";
            ENT = "";
            SSN = "";
            BIRTHDATE = "";
            EIN = "";
            MERGED_ADDRESS = "";
            Review_Flag = "";
        }
    }

    public class NotificationPopulation
    {
        [DisplayName("CRA Parent Record ID")]
        public string CRA_PARENT_RECORD_ID { get; set; }

        [DisplayName("FirstName")]
        public string FIRSTNAME { get; set; }

        [DisplayName("MiddleName")]
        public string MIDDLENAME { get; set; }

        [DisplayName("LastName")]
        public string LASTNAME { get; set; }

        [DisplayName("SSN")]
        public string SSN { get; set; }

        [DisplayName("Birthdate")]
        public string BIRTHDATE { get; set; }

        [DisplayName("EIN")]
        public string EIN { get; set; }

        [DisplayName("Address")]
        public string CRA_MERGED_ADDRESS { get; set; }

        [DisplayName("Suffix")]
        public string Suffix { get; set; }

        [DisplayName("Entity")]
        public string Entity { get; set; }

        [DisplayName("Review Flag")]
        public string Review_Flag { get; set; }

        public NotificationPopulation()
        {
            CRA_PARENT_RECORD_ID = "NA";
            FIRSTNAME = "NA";
            MIDDLENAME = "NA";
            LASTNAME = "NA";
            Suffix = "NA";
            Entity = "NA";
            SSN = "NA";
            BIRTHDATE = "NA";
            EIN = "NA";
            CRA_MERGED_ADDRESS = "NA";
            Review_Flag = "";
        }
    }

}