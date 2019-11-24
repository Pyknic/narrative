using System;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Narrative.Game
{
    public class Card : StoryNode
    {
        public string Body { get; set; }

        public string BodyText(CardContext context)
        {
            var body = Body;
            var message = new StringBuilder();
            var script  = new StringBuilder();

            foreach (var c in body)
            {
                if (script.Length == 0)
                {
                    if (c == '`')
                    {
                        script.Append(' ');
                    }
                    else
                    {
                        message.Append(c);
                    }
                }
                else
                {
                    if (c == '`')
                    {
                        var fullScript = script.ToString();
                        try
                        {
                            var result = CSharpScript.EvaluateAsync(
                                fullScript, 
                                globals: context,
                                options: ScriptOptions.Default.WithReferences(typeof(Gender).Assembly)
                                ).Result;
                            message.Append(result);
                        }
                        catch (CompilationErrorException e)
                        {
                            Console.WriteLine($"Error evaluating: '{fullScript}'");
                            Console.WriteLine(string.Join(Environment.NewLine, e.Diagnostics));
                            return null;
                        }
                        script.Clear();
                    }
                    else
                    {
                        script.Append(c);
                    }
                }
            }
            
            var fullMessage = message.ToString();
            Console.WriteLine($"Message: '{fullMessage}'");
            return fullMessage;
        }
    }
}