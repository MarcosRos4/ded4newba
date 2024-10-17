using ded4newba.Src.Habilities;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Charlatan : Background
    {
        readonly private Hability disguisekit = new(
            "Disguise Kit",
            "This pouch of cosmetics, hair dye, and small props lets you create disguises"+
            " that change your physical appearance. Proficiency with this kit lets you ad"+
            "d your proficiency bonus to any ability checks you make to create a visual d"+
            "isguise."
        );

        readonly private Hability forgerykit = new(
            "Forgery Kit",
            "This small box contains a variety of papers and parchments, pens and inks, "+
            "seals and sealing wax, gold and silver leaf, and other supplies necessary t"+
            "o create convincing forgeries of physical documents. Proficiency with this "+
            "kit lets you add your proficiency bonus to any ability checks you make to c"+
            "reate a physical forgery of a document."
        );

        readonly private Hability falseidentity = new(
            "False Identity",
            "You have created a second identity that includes documentation, establishe"+
            "d acquaintances, and disguises that allow you to assume this persona. Addi"+
            "tionally, you can forge documents, including official papers and personal "+
            "letters, as long as you have seen an example of the kind of document or th"+
            "e handwriting you are trying to copy."
        );
        
        public Charlatan(){
            Skills = ["Prestidigitation", "Deception", "Disguise", "Forgery"];
            Languages = [];
            Habilities.Add(disguisekit.Name, disguisekit.Description);
            Habilities.Add(forgerykit.Name, forgerykit.Description);
            Habilities.Add(falseidentity.Name, falseidentity.Description);
        }
    }
}