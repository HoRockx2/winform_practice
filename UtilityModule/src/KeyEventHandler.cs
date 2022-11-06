using System;
using System.Windows.Forms;
using WindowsFormsApp1.interop;

namespace UtilityModule
{
    public class KeyEventHandler
    {
        public void RegisterHotKey(Form form, Keys key)
        {
            Logger.Start();

            int modifiers = GetModifiers(key); // maybe, it means special keys such as ctrl, alt, shift and so on

            Logger.Info(modifiers.ToString());

            Keys k = RemoveModifiersFromKey(key);

            Logger.Info(k.ToString());

            int keyId = form.GetHashCode();
            var result =InteropUser32.RegisterHotKey((IntPtr)form.Handle, keyId, (int)modifiers, (int)k);

            Logger.Info($"Key RegisterHotkey result is : {result}");
        }

        public void UnregisterHotKey(Form form)
        {
            Logger.Start();

            try
            {
                int keyId = form.GetHashCode();
                InteropUser32.UnregisterHotKey(form.Handle, keyId);
            }
            catch(Exception e)
            {
                Logger.Info(e.StackTrace);
                Logger.Info(e.Message);
            }
        }

        private Keys RemoveModifiersFromKey(Keys key)
        {
            Logger.Start();

            return key & ~Keys.Control & ~Keys.Shift & ~Keys.Alt;
        }

        private int GetModifiers(Keys key)
        {
            Logger.Start();

            int modifiers = 0;

            if ((key & Keys.Alt) == Keys.Alt)
            {
                modifiers = modifiers | InteropUser32.MOD_ALT;
            }
            if ((key & Keys.Control) == Keys.Control)
            {
                modifiers = modifiers | InteropUser32.MOD_CONTROL;
            }
            if ((key & Keys.Shift) == Keys.Shift)
            {
                modifiers = modifiers | InteropUser32.MOD_SHIFT;
            }

            return modifiers;
        }
    }
}
