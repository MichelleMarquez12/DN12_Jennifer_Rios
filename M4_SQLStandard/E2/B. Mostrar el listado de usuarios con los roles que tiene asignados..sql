/******Mostrar el listado de usuarios con los roles que tiene asignados.********/
USE gymmanager; 
SELECT u.user_name, r.role_name
FROM users AS u
INNER JOIN userinroles AS ur ON u.idusers = ur.users_idusers
INNER JOIN roles AS r ON ur.roles_idRole = r.idRole;