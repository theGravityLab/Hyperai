using Hyperai.Messages.ConcreteModels;
using System;

namespace Hyperai.Messages
{
    public static class MessageChainBuilderExtensions
    {
        public static MessageChainBuilder AddPlain(this MessageChainBuilder builder, string text)
        {
            Plain plain = new Plain(text);
            return builder.Add(plain);
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
            return builder.Add(image);
        }

        public static MessageChainBuilder AddFace(this MessageChainBuilder builder, FaceType type)
        {
            return AddFace(builder, (int)type);
        }

        public static MessageChainBuilder AddFace(this MessageChainBuilder builder, int faceId)
        {
            Face face = new Face(faceId);
            return builder.Add(face);
        }

        public static MessageChainBuilder AddPoke(this MessageChainBuilder builder, PokeType type)
        {
            Poke poke = new Poke(type);
            return builder.Add(poke);
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
            return builder.Add(image);
        }

        public static MessageChainBuilder AddQuote(this MessageChainBuilder builder, long target)
        {
            Quote quote = new Quote(target);
            return builder.Add(quote);
        }

        public static MessageChainBuilder AddAt(this MessageChainBuilder builder, long who)
        {
            At at = new At(who);
            return builder.Add(at);
        }

        public static MessageChainBuilder AddAtAll(this MessageChainBuilder builder)
        {
            AtAll atall = new AtAll();
            return builder.Add(atall);
        }
    }
}