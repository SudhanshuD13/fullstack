
pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Code fetch ho raha hai
		cleanWs()
                checkout scm
            }
        }
	stage('Gitleaks Scan') {
    steps {
	cleanWs()
        echo 'Downloading Gitleaks binary inside Jenkins container...'
        sh """
        # Gitleaks download (Linux x64)
        curl -L https://github.com/gitleaks/gitleaks/releases/download/v8.18.2/gitleaks_8.18.2_linux_x64.tar.gz -o gitleaks.tar.gz
        
        # Extract
        tar -xzf gitleaks.tar.gz
        
        # Permissions
        chmod +x gitleaks
        
        # Scan (Ab ye local files ko scan karega, Docker volume ka koi lafda nahi)
        ./gitleaks detect --source=. --no-git --verbose
        
        # Cleanup
        rm gitleaks gitleaks.tar.gz
        """
    }
}
        stage('SonarQube Analysis') {
            steps {
                echo 'SonarQube stage coming soon...'
            }
        }
    }
}
