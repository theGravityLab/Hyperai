using System;
using Hyperai.Relations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hyperai.Abstractions.Tests.Relations
{
    [TestClass]
    public class RelationMatcherTests
    {
        [TestMethod]
        public void FriendAndFriend_True()
        {
            Friend friend = new Friend() {Identity = 123};

            RelationMatcher matcher = RelationMatcher.FromFriend(friend.Identity);
            
            Assert.IsTrue(matcher.Match(friend));
        }

        [TestMethod]
        public void FriendAndMember_False()
        {
            Friend friend = new Friend() {Identity = 123};

            RelationMatcher matcher = RelationMatcher.FromMember(321, friend.Identity);
            
            Assert.IsFalse(matcher.Match(friend));
        }

        [TestMethod]
        public void MemberAndMember_True()
        {
            Member member = new Member() {Group = new Lazy<Group>(new Group() {Identity = 321}), Identity = 123};

            RelationMatcher matcher = RelationMatcher.FromMember(member.Group.Value.Identity, member.Identity);
            
            Assert.IsTrue(matcher.Match(member));
        }

        [TestMethod]
        public void AnyMember_True()
        {
            Member member = new Member() {Group = new Lazy<Group>(new Group() {Identity = 321}), Identity = 123};

            RelationMatcher matcher = RelationMatcher.FromGroup(321);
            
            Assert.IsTrue(matcher.Match(member));
        }

        [TestMethod]
        public void AnyMember_False()
        {
            Member member = new Member() {Group = new Lazy<Group>(new Group() {Identity = 321}), Identity = 123};

            RelationMatcher matcher = RelationMatcher.FromGroup(233);
            
            Assert.IsFalse(matcher.Match(member));
        }
    }
}
