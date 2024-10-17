using ded4newba.src.Proficiencies;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Charlatan : Background
    {
        readonly private Proficiency disguisekit = new(
            "Disguise Kit",
            "This pouch of cosmetics, hair dye, and small props lets you create disguises"+
            " that change your physical appearance. Proficiency with this kit lets you ad"+
            "d your proficiency bonus to any ability checks you make to create a visual d"+
            "isguise."
        );

        readonly private Proficiency forgerykit = new(
            "Forgery Kit",
            "This small box contains a variety of papers and parchments, pens and inks, "+
            "seals and sealing wax, gold and silver leaf, and other supplies necessary t"+
            "o create convincing forgeries of physical documents. Proficiency with this "+
            "kit lets you add your proficiency bonus to any ability checks you make to c"+
            "reate a physical forgery of a document."
        );

        readonly private Proficiency falseidentity = new(
            "False Identity",
            "You have created a second identity that includes documentation, establishe"+
            "d acquaintances, and disguises that allow you to assume this persona. Addi"+
            "tionally, you can forge documents, including official papers and personal "+
            "letters, as long as you have seen an example of the kind of document or th"+
            "e handwriting you are trying to copy."
        );
        
        public Charlatan(){
            Skills = ["Prestidigitation", "Deception"];
            Languages = [];
            Proficiencies.Add(disguisekit);
            Proficiencies.Add(forgerykit);
            Proficiencies.Add(falseidentity);
        }
    }
}