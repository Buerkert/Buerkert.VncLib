﻿// Copyright 2017 The VncLib Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

using System;
using System.Windows.Input;

namespace VncLib.VncCommands
{
    public interface IRfbClient
    {
        void SendKey(KeyEventArgs e);

        void SendMouseClick(UInt16 posX, UInt16 posY, byte button);
    }
}