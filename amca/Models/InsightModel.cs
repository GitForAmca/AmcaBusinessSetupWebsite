﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace amca.Models
{
    public class InsightModel
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string PageTitle { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string IsActive { get; set; }
        public string CreatedOn { get; set; }
        public string BlogContent { get; set; }
        public string CreatedBy { get; set; }
        public string Designation { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email Id")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please give your Suitable Comments")]
        public string Usercomment { get; set; }
        public string pageUrlText { get; set; }

        public List<InsightModel> listData { get; set; }


        //for enquiry form

        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Select Code")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Invalid Mobile Number")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Select Services")]
        public string Services { get; set; }

        [Display(Name = "Name")]
        [RegularExpression(@"^[^<>.,?;:'()!~%\-_@#/*""]+$")]
        [Required(ErrorMessage = "Enter Name")]
        public string NameContact { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email Id")]
        public string EmailContact { get; set; }

        [Required(ErrorMessage = "Select Code")]
        public string CountryCodeContact { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Invalid Mobile Number")]
        public string MobileContact { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "Please give your Message")]
        [RegularExpression(@"^[^<>.,?;:'()!~%\-_@#/*""]+$")]
        public string MessageContact { get; set; }



        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email Id")]
        public string Useremail { get; set; }

        [Required(ErrorMessage = "Please give your Valid URL")]
        [Url]
        public string Userwebsite { get; set; }

        [Display(Name = "Company Name")]
        [RegularExpression(@"^[^<>.,?;:'()!~%\-_@#/*""]+$")]
        [Required(ErrorMessage = "Enter Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Name")]
        [RegularExpression(@"^[^<>.,?;:'()!~%\-_@#/*""]+$")]
        [Required(ErrorMessage = "Enter Your Name")]
        public string ConcernPerson { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Invalid Mobile Number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Select Trade License Authority")]
        public string TradeLicenseAuthority { get; set; }

        [Required(ErrorMessage = "Select Any One")]
        public string AboutAMCA { get; set; }

        [Required(ErrorMessage = "Select Service Name")]
        public string Service { get; set; }

        [Required(ErrorMessage = "Select Service Name")]
        public string SubServiceId { get; set; }

        [Required(ErrorMessage = "Enter Amount")]
        public string Amount { get; set; }

        public string VisaType { get; set; }

        public string Catagories { get; set; }

        public string University { get; set; }

        public string Specialization { get; set; }

        public string SchoolName { get; set; }

        public string country { get; set; }
        public string Emirate { get; set; }
        public string ServiceMain { get; set; }
        public string LeadDataType { get; set; }

    }


}