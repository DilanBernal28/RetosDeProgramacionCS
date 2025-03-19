namespace RetodDeProgramacion.Model;

public record ChallengeCompleted(
        int number,
        string name,
        Difficulty? difficulty
    );