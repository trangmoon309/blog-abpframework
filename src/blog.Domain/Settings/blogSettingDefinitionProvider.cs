using Volo.Abp.Settings;

namespace blog.Settings
{
    public class blogSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(blogSettings.MySetting1));
        }
    }
}
