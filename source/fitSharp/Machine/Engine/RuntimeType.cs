﻿// Copyright © 2012 Syterra Software Inc. All rights reserved.
// The use and distribution terms for this software are covered by the Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file license.txt at the root of this distribution. By using this software in any fashion, you are agreeing
// to be bound by the terms of this license. You must not remove this notice, or any other, from this software.

using System;
using fitSharp.Machine.Exception;
using fitSharp.Machine.Model;

namespace fitSharp.Machine.Engine {
    public class RuntimeType {

        public Type Type { get; private set; }

        public RuntimeType(Type type) {
            Type = type;
        }

        public RuntimeMember FindStatic(MemberName memberName, Type[] parameterTypes) {
            return new MemberQuery(memberName, parameterTypes.Length)
                .WithParameterTypes(parameterTypes)
                .StaticOnly()
                .FindMember(Type);
        }

        public RuntimeMember GetConstructor(int parameterCount) {
            RuntimeMember runtimeMember = new MemberQuery(MemberName.Constructor, parameterCount).FindMember(Type);
            if (runtimeMember == null) throw new ConstructorMissingException(Type, parameterCount);
            return runtimeMember;
        }

        public RuntimeMember FindConstructor(Type[] parameterTypes) {
            return new MemberQuery(MemberName.Constructor, parameterTypes.Length)
                .WithParameterTypes(parameterTypes)
                .FindMember(Type);
        }


        public TypedValue CreateInstance() {
            return new TypedValue(Type.Assembly.CreateInstance(Type.FullName), Type);
        }
    }
}
