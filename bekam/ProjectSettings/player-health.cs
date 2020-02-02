using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehavior {
    public int healthBase = 100;            // base player health
    public int currentHealth;               // amount of health player currently has

    bool isCritical = false;                // states if player's health is critical
    bool isDead = false;                    // checks if player is dead
    

    // sets player's health at start of a stage
    void initialize () {
        currentHealth = healthBase;
    }

    // adjusts player's health when attacked
    void takeDamage (int incDamage) {
        currentHealth -= incDamage;

        // triggers death stage if health falls to 0 or below
        if (currentHealth <= 0 && !isDead) {
            playerDeath();
        }
    }

    void playerDeath() {
        isDead = true;

        // disable various player controls
        // at some point
    }

}