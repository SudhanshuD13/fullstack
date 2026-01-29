
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
                echo 'Scanning for secrets...'
                // Humne $(pwd) ko /path pe mount kiya hai, ab uske andar ki files scan karenge
                sh 'docker run --rm -v $(pwd):/path zricethezav/gitleaks:latest detect --source="/path" --no-git --verbose'
            }
        }
        stage('SonarQube Analysis') {
            steps {
                echo 'SonarQube stage coming soon...'
            }
        }
    }
}
