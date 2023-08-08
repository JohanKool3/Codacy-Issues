using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Codacy_Issues.Code_Style_Issues
{
    internal class CommentedOutCode
    {


        public string filePath = "/DefaultLocation/";




        public void UpdateFilePath(string filePathIn)
        {
            filePath = filePathIn;
            //TODO: Add validation to ensure that the filePath is valid (ticket ex2985)

        }

        public string ReadFile(string filePathIn)
        {

            return File.ReadAllText(filePathIn);

        }
    }
}
