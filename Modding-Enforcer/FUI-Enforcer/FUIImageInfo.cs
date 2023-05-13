using FUI_Enforcer.Classes;
using System.Collections.Generic;

namespace FUI_Enforcer
{
    class FUIImageInfo
    {
        public static readonly int NativeSize = 32;

        private int descriptor;
        private int attribute;
        private int imageWidth;
        private int imageHeight;
        private int imageOffset;
        private int imageSize;
        private int unkOffset;
        private int unk_0x1C;

        public FUIImageInfo()
        {

        }

        public void Read(byte[] filedata, int startIndex)
        {
            descriptor = FUIUtils.ToInt32(filedata, startIndex + 0);
            attribute = FUIUtils.ToInt32(filedata, startIndex + 4);
            imageWidth = FUIUtils.ToInt32(filedata, startIndex + 8);
            imageHeight = FUIUtils.ToInt32(filedata, startIndex + 12);
            imageOffset = FUIUtils.ToInt32(filedata, startIndex + 16);
            imageSize = FUIUtils.ToInt32(filedata, startIndex + 20);
            unkOffset = FUIUtils.ToInt32(filedata, startIndex + 24);
            unk_0x1C = FUIUtils.ToInt32(filedata, startIndex + 28);
        }

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();

            byteList.AddRange(FUIUtils.GetBytes(descriptor));
            byteList.AddRange(FUIUtils.GetBytes(attribute));
            byteList.AddRange(FUIUtils.GetBytes(imageWidth));
            byteList.AddRange(FUIUtils.GetBytes(imageHeight));
            byteList.AddRange(FUIUtils.GetBytes(imageOffset));
            byteList.AddRange(FUIUtils.GetBytes(ImageSize));
            byteList.AddRange(FUIUtils.GetBytes(unkOffset));
            byteList.AddRange(FUIUtils.GetBytes(unk_0x1C));

            return byteList.ToArray();
        }

        public int ImageOffset
        {
            get => imageOffset;
            set => imageOffset = value;
        }

        public int ImageSize
        {
            get => imageSize;
            set => imageSize = value;
        }

        public int Width
        {
            get => imageWidth;
            set => imageWidth = value;
        }

        public int Height
        {
            get => imageHeight;
            set => imageHeight = value;
        }

        public int Descriptor
        {
            get => descriptor;
            set => descriptor = value;
        }

        public int Attribute
        {
            get => attribute;
            set => attribute = value;
        }
    }
}