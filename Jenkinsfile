
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
        echo 'Scanning for secrets with Root Permissions...'
        // -u 0:0 se hum root ban kar scan karenge taaki koi file na Chhute
        sh 'docker run --rm -u 0:0 -v ${WORKSPACE}:/path zricethezav/gitleaks:latest detect --source="/path" --no-git --verbose'
    }
}
        stage('SonarQube Analysis') {
            steps {
                echo 'SonarQube stage coming soon...'
            }
        }
    }
}
