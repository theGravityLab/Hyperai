using Hyperai.Messages.ConcreteModels;
using System;

namespace Hyperai.Messages
{
    public static class MessageChainBuilderExtensions
    {
        public static MessageChainBuilder AddPlain(this MessageChainBuilder builder, string text)
        {
            Plain plain = new Plain(text);
            builder.Add(plain);
            return builder;
        }

        public static MessageChainBuilder AddImage(this MessageChainBuilder builder, Uri url)
        {
            return AddImage(builder, null, url);
        }

        public static MessageChainBuilder AddImage(this MessageChainBuilder builder, string imageId)
        {
            return AddImage(builder, imageId, null);
        }

        public static MessageChainBuilder AddImage(this MessageChainBuilder builder, string imageId, Uri url)
        {
            Image image = new Image(imageId, url);
            builder.Add(image);
            return builder;
        }

        public static MessageChainBuilder AddFace(this MessageChainBuilder builder, FaceType type)
        {
            return AddFace(builder, (int)type);
        }

        public static MessageChainBuilder AddFace(this MessageChainBuilder builder, int faceId)
        {
            Face face = new Face(faceId);
            builder.Add(face);
            return builder;
        }

        public static MessageChainBuilder AddPoke(this MessageChainBuilder builder, PokeType type)
        {
            Poke poke = new Poke(type);
            builder.Add(poke);
            return builder;
        }

        public static MessageChainBuilder AddFlash(this MessageChainBuilder builder, Uri url)
        {
            return AddFlash(builder, null, url);
        }

        public static MessageChainBuilder AddFlash(this MessageChainBuilder builder, string imageId)
        {
            return AddFlash(builder, imageId, null);
        }

        public static MessageChainBuilder AddFlash(this MessageChainBuilder builder, string imageId, Uri url)
        {
            Flash image = new Flash(imageId, url);
            builder.Add(image);
            return builder;
        }
    }
}
