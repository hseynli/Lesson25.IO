// D diskində dəyişikliklərin izlənilməsi.
FileSystemWatcher watcher = new FileSystemWatcher { Path = @"D:\" };

// Hadisəni qeydiyyatdan keçirmək.
watcher.Created += new FileSystemEventHandler(WatcherChanged);
watcher.Deleted += WatcherChanged;
watcher.Renamed += WatcherRenamed;

// Monitorinqə başlamaq.
watcher.EnableRaisingEvents = true;

// Delay.
var change = watcher.WaitForChanged(WatcherChangeTypes.All);
Console.WriteLine(change.ChangeType);

Console.ReadKey();

// Event handler.
static void WatcherChanged(object sender, FileSystemEventArgs e)
{
    Console.WriteLine("Directory changed({0}): {1}", e.ChangeType, e.FullPath);
}

static void WatcherRenamed(object sender, FileSystemEventArgs e)
{
    Console.WriteLine("Directory changed({0}): {1}", e.ChangeType, e.FullPath);
}