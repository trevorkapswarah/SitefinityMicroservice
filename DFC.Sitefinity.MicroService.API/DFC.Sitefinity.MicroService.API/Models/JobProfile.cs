﻿using System;
using MongoDB.Bson.Serialization.Attributes;

namespace DFC.Sitefinity.MicroService.API.Models
{
    public class JobProfile
    {
        public Guid Id { get; set; }
        [BsonId]
        public string UrlName { get; set; }

        public string Title { get; set; }

        public string AlternativeTitles { get; set; }

        public string Overview { get; set; }

        public string SalaryDescription { get; set; }

        public string SkillsYoullNeed { get; set; }

        public string EntryRequirements { get; set; }

        public string WhatYoullDo { get; set; }

        public string WorkingHoursPatternsAndEnvironment { get; set; }

        public string CareerPathAndProgression { get; set; }
        public string HowToBecome { get; set; }
        public string Skills { get; set; }
    }
}
