pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Code fetch ho raha hai
                checkout scm
            }
        }

        stage('Gitleaks Scan') {
            steps {
                echo 'Scanning for secrets using Docker...'
                // Hum Docker ke zariye gitleaks chalayenge taaki installation ka jhanjhat na ho
                sh 'docker run --rm -v $(pwd):/path zricethezav/gitleaks:latest detect --source="/path" -v'
            }
        }
        
        stage('SonarQube Analysis') {
            steps {
                echo 'SonarQube stage coming soon...'
            }
        }
    }
}
