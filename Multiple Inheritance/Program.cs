
// Multiple Inheritance - a class can have multiple base classes (C# doesnt' do this)

// you do not inherit code from an interface, there is no reuse-ability
//confirm that the public interface of our class has the members or methods as declared in the interface

public class TextBox : UiControl, IDraggable, IDroppable
{
    public void Drag()
    {
        throw new NotImplementedException();
    }

    public void Drop()
    {
        throw new NotImplementedException();
    }
}