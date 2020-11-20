namespace blog.Permissions
{
    public static class blogPermissions
    {
        public const string GroupName = "blogproject";
        public static class Post
        {
            public const string CreatePost = GroupName + ".Post.Create";
            public const string UpdatePost = GroupName + ".Post.Update";
        }
        public static class Category
        {
            public const string CreateCategory = GroupName + ".Category.Create";
            public const string UpdateCategory = GroupName + ".Category.Update";
        }
        public static class User
        {
            public const string UpdateProfile = GroupName + ".Profile.Update";
            public const string ManageUser = GroupName + ".User.Manager";
        }

        public static class Author
        {
            public const string ManageRole = GroupName + ".Role.Manager";
            public const string ManagePermission = GroupName + ".Permission.Manage";
        }
        
    }
}