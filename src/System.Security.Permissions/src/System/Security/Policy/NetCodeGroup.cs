﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Policy
{
    public sealed partial class NetCodeGroup : System.Security.Policy.CodeGroup
    {
        public static readonly string AbsentOriginScheme;
        public static readonly string AnyOtherOriginScheme;
        public NetCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition) : base(default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
        public override string AttributeString { get { return null; } }
        public override string MergeLogic { get { return null; } }
        public override string PermissionSetName { get { return null; } }
        public void AddConnectAccess(string originScheme, System.Security.Policy.CodeConnectAccess connectAccess) { }
        public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
        protected override void CreateXml(SecurityElement element, System.Security.Policy.PolicyLevel level) { }
        public override bool Equals(object o) => base.Equals(o);
        public System.Collections.DictionaryEntry[] GetConnectAccessRules() { return default(System.Collections.DictionaryEntry[]); }
        public override int GetHashCode() => base.GetHashCode();
        protected override void ParseXml(SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public void ResetConnectAccess() { }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
    }
}
