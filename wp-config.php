<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'FirstWPDb' );

/** MySQL database username */
define( 'DB_USER', 'root' );

/** MySQL database password */
define( 'DB_PASSWORD', 'root' );

/** MySQL hostname */
define( 'DB_HOST', '127.0.0.1:3307' );//'localhost:3307' );

/** Database Charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The Database Collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         '+VoP]MsSg}w;MkZB^T1zk]9ta+q(ycI?EXH-L`g`&?DiS+:cf>fQEz5k~5rS=oe9' );
define( 'SECURE_AUTH_KEY',  '_K;!ce]hee:4-um*E-&6g+!jL6{(6Z;A]Vl`d,$ou:E]IHx@*XwW5J2NpdKh8`MY' );
define( 'LOGGED_IN_KEY',    'gktFX3 N$L^r>itOnRG/8icyiI@4Kr3gboMTVf<+,F(T7CERPC4pk~KF;/Ov<}v]' );
define( 'NONCE_KEY',        't}zr%hWhF*Zunzj+95M!p*Bh.R?_d/4kVzIpx=umgBUec^GAmghzthz&V4/CGL>W' );
define( 'AUTH_SALT',        'Z/m#)XLU_6<eT8z,RgWx|-gI*j{JGacmQU7WRJ/167vk#F<7K{h+3x65Py;$}QhA' );
define( 'SECURE_AUTH_SALT', 'uLVi=SXDCb/7BOo0h>T*Uk@=vP9hqg(,*%c@^]}qwZlv+k}9$6c<tS9eBainnm`<' );
define( 'LOGGED_IN_SALT',   '(N[v)w>)H;,=4]`=|p:5#ABX&`Of;|fY|}C>w!0KHZu+;rBj2 /h6`e}Yu}]%|Hf' );
define( 'NONCE_SALT',       '7SUO9u%Up O,-?|x#Ol{[]<sY!u$+8R@R-u,9YNyF%a[{Ma}$;fZ5~D/*jk1Q9Q7' );

/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/support/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';