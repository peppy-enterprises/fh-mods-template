using System.IO;

using Fahrenheit.Core;

namespace Fahrenheit.Modules.Template;

[FhLoad(FhGameType.FFX)]
public class TemplateModule : FhModule {
    public TemplateModule() { }

    public override bool init(FileStream global_state_file) { }

    public override void load_local_state(FileStream? local_state_file, FhLocalStateInfo local_state_info) { }
    public override void save_local_state(FileStream  local_state_file)                                    { }
}
