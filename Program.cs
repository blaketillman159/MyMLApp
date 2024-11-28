using MyMLApp;

Console.WriteLine("Write a theoretical review of a restaurant left by a user on Yelp, and i predict it was positive or negative.");
Console.WriteLine("SAMPLES:");
Console.WriteLine(" - Wow... Loved this place.");
Console.WriteLine(" - Crust is not good.");
Console.WriteLine(" - Not tasty and the texture was just nasty.");
Console.WriteLine("");

while (true)
{
    Console.WriteLine("Write a sentence: ...[ENTER]");
    var sentence = Console.ReadLine();

    // Add input data
    var sampleData = new SentimentModel.ModelInput()
    {
        Col0 = sentence
    };

    // Load model and predict output of sample data
    var result = SentimentModel.Predict(sampleData);

    // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
    var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Sentiment: {sentiment}");
    Console.WriteLine("");
}
