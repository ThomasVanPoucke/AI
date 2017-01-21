using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources.Core;
using Windows.Globalization;
using Windows.Media.SpeechRecognition;

namespace AI
{
    /// <summary>
    /// 
    /// </summary>
    /// Author: Thomas Van Poucke
    public class InteractionManager
    {
        private ResourceContext speechContext;
        private ResourceMap speechResourceMap;

        public InteractionManager()
        {
            // Initialize resource map to retrieve localized speech strings.
            Language speechLanguage = SpeechRecognizer.SystemSpeechLanguage;
            string langTag = speechLanguage.LanguageTag;
            speechContext = ResourceContext.GetForCurrentView();
            speechContext.Languages = new string[] { langTag };

            speechResourceMap = ResourceManager.Current.MainResourceMap.GetSubtree("Interaction");
        }

        /// Return a list with all questions
        public List<string> GetAllQuestions()
        {


            List<string> questions = new List<string>();

            foreach (string key in speechResourceMap.Keys)
            {
                if(key.EndsWith("question"))
                    questions.Add(speechResourceMap.GetValue(key, speechContext).ValueAsString);
            }

            return questions;
        }

        /// Get ID of the question or answer
        public string GetID(string value)
        {
            Debug.WriteLine("parameter: " + value);
            Debug.WriteLine("speechResourceMap.Keys: First key:" + speechResourceMap.Keys.First());
            Debug.WriteLine("Value first key: " + speechResourceMap.GetValue(speechResourceMap.Keys.First(),speechContext).ValueAsString);
            foreach (var key in speechResourceMap.Keys.ToList())
            {
                if (speechResourceMap.GetValue(key, speechContext).ValueAsString == value)
                    return key;
            }

            //no key found
            return "";
        }

        /// Get the answer for a question
        public string GetAnswer(string question)
        {
            //Get id of question
            string questionId = GetID(question);
            //Determine id of answer
            //remove '.question', add '.answer'
            string answerId = string.Concat(questionId.Substring(0, questionId.Length - 9),"/answer");

            //Get and return answer
            string answer = speechResourceMap.GetValue(answerId, speechContext).ValueAsString;
            return answer;
        }
        
    }
}
