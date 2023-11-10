namespace RockPaperScissors.Components.Game;

public partial class PlayerContainer
{
    [Parameter, EditorRequired]
    public string PlayerName { get; set; } = string.Empty;
}
