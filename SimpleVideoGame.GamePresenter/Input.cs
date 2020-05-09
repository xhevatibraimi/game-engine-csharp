using System.Collections.Concurrent;

namespace SimpleVideoGame.GamePresenter
{
    public static class Input
    {
        private static ConcurrentDictionary<string, bool> downKeys = new ConcurrentDictionary<string, bool>();

        public static void SetKeyDown(string key, bool isDown)
        {
            downKeys[key.ToLower()] = isDown;
        }

        public static bool IsKeyDown(string key)
        {
            if (downKeys.TryGetValue(key.ToLower(), out bool isDown))
                return isDown;

            return false;
        }
    }
}
