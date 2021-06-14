using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationList.Models
{
    public class OverGroup
    {
        public string relativityid { get; set; }
        public string CRA_UNIQUE_ID { get; set; }
        public string CRA_PARENT_RECORD_ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string LASTNAME { get; set; }
        public string SSN { get; set; }
        public string BIRtHDATE { get; set; }
        public string EIN { get; set; }
        public string CRA_MERGED_ADDRESS { get; set; }

        public OverGroup()
        {
            relativityid = "NA";
            CRA_UNIQUE_ID = "NA";
            CRA_PARENT_RECORD_ID = "NA";
            FIRSTNAME = "NA";
            FIRSTNAME = "NA";
            MIDDLENAME = "NA";
            LASTNAME = "NA";
            SSN = "NA";
            BIRtHDATE = "NA";
            EIN = "NA";
            CRA_MERGED_ADDRESS = "NA";
        }


        public OverGroup(string relativityid, string cRA_UNIQUE_ID, string cRA_PARENT_RECORD_ID, string fIRSTNAME, string mIDDLENAME, string lASTNAME, string sSN, string bIRtHDATE, string eIN, string cRA_MERGED_ADDRESS)
        {
            this.relativityid = relativityid;
            CRA_UNIQUE_ID = cRA_UNIQUE_ID;
            CRA_PARENT_RECORD_ID = cRA_PARENT_RECORD_ID;
            FIRSTNAME = fIRSTNAME;
            MIDDLENAME = mIDDLENAME;
            LASTNAME = lASTNAME;
            SSN = sSN;
            BIRtHDATE = bIRtHDATE;
            EIN = eIN;
            CRA_MERGED_ADDRESS = cRA_MERGED_ADDRESS;
        }


    }

    public class Entity
    {
        public string PARENT_RECORD { get; set; }
        public string ENT { get; set; }
        public string SSN { get; set; }
        public string BIRTHDATE { get; set; }
        public string EIN { get; set; }
        public string MERGED_ADDRESS { get; set; }

        public Entity()
        {
            PARENT_RECORD = "";
            ENT = "";
            SSN = "";
            BIRTHDATE = "";
            EIN = "";
            MERGED_ADDRESS = "";
        }
    }


}