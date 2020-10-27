using System;

public class Class1
{
	public Class1()
	{
		XMLReader reader = XmlReader.Create("http://www.svt.se/nyheter/rss.xml");
		SyndicationFeed feed = SyndicationFeed.Load(reader);
        Console.WriteLine("--- Title: " + feed.Title.Text);
        Console.WriteLine("--- Description: " + feed.Description.Text);
		
		foreach (SyndicationItem item in feed.Items)
        {
            Console.WriteLine(item.Title.Text);
            Console.WriteLine("->" + item.Summary.Text);
        }

	}
}
