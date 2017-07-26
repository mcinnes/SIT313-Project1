using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONTest
{
    public class QuizHandler
    {
        [JsonProperty("")]
        public Quiz Quiz { get; set; }
        
        public QuizHandler()
        {
        
        }
           

        
    }
}
