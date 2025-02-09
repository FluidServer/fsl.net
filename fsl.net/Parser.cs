using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsl.net
{
    public class Parser
    {
        public Dictionary<string, string> Parse(string input)
        {
            if(input == "" || input == null) { throw new Exception("Input cannot be null"); }
            string[] split = input.Split('\n');

            string fslVersion = split[0].Replace(" ", "").ToString().Split(',')[1].Split('.')[0];

            var settings = new Dictionary<string, string>
            {
                { "Version", fslVersion }
            };

            for (int i = 0; i < split.Length - 1; i++)
            {
                var pairs = split[i].Split('=');

                if(split[i].StartsWith(";") || split[i].StartsWith(":")) { continue; }
                if(pairs.Length != 2) { continue; }
                try {
                    settings.Add(pairs[0], pairs[1]);
                } catch { continue; }
            }

            return settings; 
        }
    }
}
