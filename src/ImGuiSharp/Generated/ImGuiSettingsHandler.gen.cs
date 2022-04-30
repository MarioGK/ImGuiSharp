// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiSettingsHandler
{
    public char* TypeName;
    public uint TypeHash;
    public void(*)(ImGuiContext* ctx,ImGuiSettingsHandler* handler) ClearAllFn;
    public void(*)(ImGuiContext* ctx,ImGuiSettingsHandler* handler) ReadInitFn;
    public void*(*)(ImGuiContext* ctx,ImGuiSettingsHandler* handler, char* name) ReadOpenFn;
    public void(*)(ImGuiContext* ctx,ImGuiSettingsHandler* handler,void* entry, char* line) ReadLineFn;
    public void(*)(ImGuiContext* ctx,ImGuiSettingsHandler* handler) ApplyAllFn;
    public void(*)(ImGuiContext* ctx,ImGuiSettingsHandler* handler,ImGuiTextBuffer* out_buf) WriteAllFn;
    public void* UserData;

}
