// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: ccrf_type_fusion_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CcrfTypeFusionConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CcrfTypeFusionConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string classifiers_property_file_path
        {
            get { return __pbn__classifiers_property_file_path ?? ""; }
            set { __pbn__classifiers_property_file_path = value; }
        }
        public bool ShouldSerializeclassifiers_property_file_path()
        {
            return __pbn__classifiers_property_file_path != null;
        }
        public void Resetclassifiers_property_file_path()
        {
            __pbn__classifiers_property_file_path = null;
        }
        private string __pbn__classifiers_property_file_path;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string transition_property_file_path
        {
            get { return __pbn__transition_property_file_path ?? ""; }
            set { __pbn__transition_property_file_path = value; }
        }
        public bool ShouldSerializetransition_property_file_path()
        {
            return __pbn__transition_property_file_path != null;
        }
        public void Resettransition_property_file_path()
        {
            __pbn__transition_property_file_path = null;
        }
        private string __pbn__transition_property_file_path;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(1.8f)]
        public float transition_matrix_alpha
        {
            get { return __pbn__transition_matrix_alpha ?? 1.8f; }
            set { __pbn__transition_matrix_alpha = value; }
        }
        public bool ShouldSerializetransition_matrix_alpha()
        {
            return __pbn__transition_matrix_alpha != null;
        }
        public void Resettransition_matrix_alpha()
        {
            __pbn__transition_matrix_alpha = null;
        }
        private float? __pbn__transition_matrix_alpha;

    }

}

#pragma warning restore 0612, 1591, 3021