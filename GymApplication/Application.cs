class Program {
    [STAThread]
    static async Task Main(string[] args) {
        Logger.Logger.Trace().Cid("Trace").Log("");
        Logger.Logger.Critical().Cid("Critical").Log("");
        Logger.Logger.Debug().Cid("Debug").Log("");
        Logger.Logger.Error().Cid("Error").Log("");
        Logger.Logger.Warn().Cid("Warn").Log("");
        Logger.Logger.Info().Cid("Info").Log("");

        // Simulate running app with graceful exit on Ctrl+C
        Console.CancelKeyPress += (s, e) => {
            Environment.Exit(0);
        };
        while (true) {
            Logger.Logger.Info().Log("Client is running - Ctr + C to exit");
            await Task.Delay(60000);
        }
    }
}
