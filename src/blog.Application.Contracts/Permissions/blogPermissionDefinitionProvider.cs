using blog.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace blog.Permissions
{
    public class blogPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(blogPermissions.GroupName);

            var postPermission = myGroup.AddPermission("Post");
            postPermission.AddChild(blogPermissions.Post.CreatePost);
            postPermission.AddChild(blogPermissions.Post.UpdatePost);

            var catePermission = myGroup.AddPermission("Category");
            catePermission.AddChild(blogPermissions.Category.CreateCategory);
            catePermission.AddChild(blogPermissions.Category.UpdateCategory);

            var userPermission = myGroup.AddPermission("User");
            userPermission.AddChild(blogPermissions.User.ManageUser);
            userPermission.AddChild(blogPermissions.User.UpdateProfile);

            var authorPermission = myGroup.AddPermission("Author");
            authorPermission.AddChild(blogPermissions.Author.ManageRole);
            authorPermission.AddChild(blogPermissions.Author.ManagePermission);

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<blogResource>(name);
        }
    }
}
