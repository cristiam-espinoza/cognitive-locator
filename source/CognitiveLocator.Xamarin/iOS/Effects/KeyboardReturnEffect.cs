﻿using CognitiveLocator.iOS.Effects;

[assembly: ExportEffect(typeof(KeyboardReturnEffect), "KeyboardReturnEffect")]

namespace CognitiveLocator.iOS.Effects
{
    public class KeyboardReturnEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control == null)
                return;

            var editText = Control as UIKit.UITextField;
            editText.ReturnKeyType = UIKit.UIReturnKeyType.Next;
        }

        protected override void OnDetached()
        {
        }
    }
}