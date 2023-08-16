// See https://aka.ms/new-console-template for more information

using Codacy_Issues.Code_Style_Issues;
using Codacy_Issues.Error_Prone_Issues;

Example example = new ();

NoOptionalParameters noOptionalParameters = new ();

noOptionalParameters.Eat("pizza", 2, true);
Console.WriteLine(noOptionalParameters.Add(1).ToString());

noOptionalParameters.Notify("Codacy", 10);
