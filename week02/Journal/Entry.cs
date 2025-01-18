using System;

public class Entry
{
    private string prompt;
    private string response;
    private DateTime date;

    public Entry(string prompt, string response)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = DateTime.Now;
    }

    public string GetPrompt()
    {
        return prompt;
    }

    public string GetResponse()
    {
        return response;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public override string ToString()
    {
        return $"Date: {date}\nPrompt: {prompt}\nResponse: {response}\n";
    }
}