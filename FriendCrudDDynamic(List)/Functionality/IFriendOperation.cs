using FriendAppCustomised.Models;
using System;


namespace FriendAppCustomised.Functionality
{
    public interface IFriendOperation

    {
        void createFriend();
        List<Friend> getFriendList();

        void removeFriend();

        void updateFriend();

        void searchFriend();
        void insertFriend();
    }
}
