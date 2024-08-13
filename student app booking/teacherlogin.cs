.login-container {
	width: 350px;
	margin: 50px auto;
	padding: 20px;
	background-color:#fff;
	background-color: #f5f5f5;
	border: 1px solid #ccc;
	box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
	border-radius: 10px;
}
p{
	text-align: center;
	font-weight: 18px;
	font-size: large;
}

body{
	background-color: #939b9c;
}

h1 {
	text-align: center;
	margin-bottom: 20px;
	color: #000000;
}

form {
	display: flex;
	flex-direction: column;
	align-items: center;
}

label {
	margin-bottom: 10px;
	color: #000000;
	font-size: 18px;
	font-weight: bold;
}

input[type="text"], input[type="password"] {
	width: 100%;
	padding: 10px;
	margin-bottom: 20px;
	border: 1px solid #ccc;
	border-radius: 10px;
}

button {
	width: 100%;
	padding: 10px;
	background-color: #150c78;
	color: #fff;
	border: none;
	border-radius: 10px;
	cursor: pointer;
	box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
	animation: pulse 2s infinite;
}

button[type="submit"]:hover {
	background-color:#105f0a;
}

/* Add some animations to make it more attractive */
@keyframes fadeIn {
	0% {
		opacity: 0;
	}
	100% {
		opacity: 1;
	}
}

@keyframes pulse {
	0% {
		transform: scale(1);
	}
	50% {
		transform: scale(1.1);
	}
	100% {
		transform: scale(1);
	}
}

.login-container {
	animation: fadeIn 1s;
}