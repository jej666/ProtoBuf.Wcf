using ProtoBuf.Meta;

namespace ProtoBuf.Wcf.Channels.Serialization
{
    public sealed class ModelInfo
    {
        public RuntimeTypeModel Model { get; private set; }
        public TypeMetaData MetaData { get; private set; }

        internal ModelInfo(RuntimeTypeModel model, TypeMetaData metaData)
        {
            Model = model;
            MetaData = metaData;
        }
    }
}