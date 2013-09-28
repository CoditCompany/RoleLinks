namespace CoditBlog.RoleLinks.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CoditBlog.RoleLinks.InvoiceOut",@"InvoiceOut")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InvoiceOut"})]
    public sealed class InvoiceOut : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CoditBlog.RoleLinks.InvoiceOut"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CoditBlog.RoleLinks.InvoiceOut"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""InvoiceOut"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""InvoiceNumber"" type=""xs:string"" />
        <xs:element name=""Currency"" type=""xs:string"" />
        <xs:element name=""DestinationNumber"" type=""xs:string"" />
        <xs:element name=""NumberOfItems"" type=""xs:string"" />
        <xs:element name=""Weight"" type=""xs:string"" />
        <xs:element name=""UnitOfMeasure"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InvoiceOut() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "InvoiceOut";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
