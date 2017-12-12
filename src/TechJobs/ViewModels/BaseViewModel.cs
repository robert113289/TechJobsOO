﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;
using System.ComponentModel.DataAnnotations;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // The search results
        public List<Job> Jobs { get; set; }

        // The column to search, defaults to all
        public JobFieldType Column { get; set; } = JobFieldType.All;

        // The search value
        [Display(Name = "Keyword:")]
        public string Value { get; set; } = "";

        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

        // View title
        public string Title { get; set; } = "";
    }
}
