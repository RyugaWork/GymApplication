
class Program {
    [STAThread]
    static async Task Main(string[] args) {
        Logger.Core.Logger.Trace().Cid("Trace").Log("");
        Logger.Core.Logger.Critical().Cid("Critical").Log("");
        Logger.Core.Logger.Debug().Cid("Debug").Log("");
        Logger.Core.Logger.Error().Cid("Error").Log("");
        Logger.Core.Logger.Warn().Cid("Warn").Log("");
        Logger.Core.Logger.Info().Cid("Info").Log("");

        // Simulate running app with graceful exit on Ctrl+C
        Console.CancelKeyPress += (s, e) => {
            Environment.Exit(0);
        };
        while (true) {
            Logger.Core.Logger.Info().Log("Client is running - Ctr + C to exit");
            await Task.Delay(60000);
        }
    }
}
