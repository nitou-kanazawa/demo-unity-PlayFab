using UnityEngine;

/// <summary>
/// Supported Authentication types
/// Note: Add types to there to support more AuthTypes
/// See - https://api.playfab.com/documentation/client#Authentication
/// </summary>
public enum AuthTypes {
    None,
    Silent,
    // 
    UsernameAndPassword,
    EmailAndPassword,
    // 
    RegisterPlayFabAccount,
    Steam,
    Facebook,
    Google
}