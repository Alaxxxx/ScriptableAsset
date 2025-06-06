﻿using System;
using ScriptableAsset.Core;

namespace ScriptableAsset.Base.Primitive
{
      [Serializable]
      public class ReactiveInt : ReactiveValue<int>
      {
            public ReactiveInt()
            {
            }

            public ReactiveInt(string name, int initialValue) : base(name, initialValue)
            {
            }
      }
}