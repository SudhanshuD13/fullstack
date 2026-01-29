pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                echo 'Fetching code from GitHub...'
            }
        }

        stage('Gitleaks Scan') {
            steps {
                echo 'Scanning for secrets...'
                // Ye command humne pehle install ki thi
                sh 'gitleaks detect --source . -v'
            }
        }
    }
}
