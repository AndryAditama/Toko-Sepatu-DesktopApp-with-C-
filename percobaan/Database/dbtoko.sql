-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Waktu pembuatan: 14 Jan 2022 pada 09.06
-- Versi server: 10.3.15-MariaDB
-- Versi PHP: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtoko`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbbarang`
--

CREATE TABLE `tbbarang` (
  `idbarang` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `ukuran` int(3) NOT NULL,
  `warna` varchar(20) NOT NULL,
  `harga` int(10) NOT NULL,
  `gambar` varchar(500) NOT NULL,
  `urlgambar` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbbarang`
--

INSERT INTO `tbbarang` (`idbarang`, `nama`, `ukuran`, `warna`, `harga`, `gambar`, `urlgambar`) VALUES
(3, 'jkad', 39, 'hijau', 60000, 'ÿØÿà\0JFIF\0\0\0\0\0\0\0ÿÛ\0C\0\n\n\n\n\n\n\"\Z\Z\"3 %  % 3-7,),7-Q@88@Q^OJO^qeeqˆ»»ûÿÛ\0C\n\n\n\n\n\n\"\Z\Z\"3 %  % 3-7,),7-Q@88@Q^OJO^qeeqˆ»»ûÿÂ\088\"\0ÿÄ\0\0\0\0\0\0\0\0\0\0\0\0\0\0ÿÄ\0\Z\0\0\0\0\0\0\0\0\0\0ÿÚ\0\0\0\0\0ÝÓŠœ]1\0Å(ÄJ$L€Œ‚2C\0n2#$‰8¢CA0#!ƒLi7LC*c+*r‹F d$ªPÔ•8Ê¢S€Y\\¢N(†„J,¡ D¢Üd´‰E²%ŠZ§4@“ ‘$¹„	!)	¢\nH@*‰£ Åš`†tuõ›Iê nM(nÍrôœŠt§.öÄ©%	l!\"6&QÄÄ0ÁŒŠ˜&\"I¡€›ŒÄ8“L#4„)	ÛA;	,B\Z\'M„I²²È‘S“È‘Q˜ˆÍ5õ.ÐÓåibo\rqÑGŸGFs‘:c’', 'D:\\digu\\evdaimonhype.co-20210112-0007.jpg');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpengeluaran`
--

CREATE TABLE `tbpengeluaran` (
  `id` int(10) NOT NULL,
  `keperluan` varchar(50) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `tanggal` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbpengeluaran`
--

INSERT INTO `tbpengeluaran` (`id`, `keperluan`, `jumlah`, `tanggal`) VALUES
(1, 'beli barang baru', 100000, '14 Januari 2022'),
(2, 'uang buat liburan', 1000000, '14 Januari 2022');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbtransaksi`
--

CREATE TABLE `tbtransaksi` (
  `idtransaksi` int(10) NOT NULL,
  `idbarang` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `ukuran` int(3) NOT NULL,
  `warna` varchar(30) NOT NULL,
  `harga` int(10) NOT NULL,
  `tanggal` varchar(50) NOT NULL,
  `admin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbtransaksi`
--

INSERT INTO `tbtransaksi` (`idtransaksi`, `idbarang`, `nama`, `ukuran`, `warna`, `harga`, `tanggal`, `admin`) VALUES
(1, 1, 'sepatu kw', 40, 'merah', 30000, '14 Januari 2022', 'admin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbuser`
--

CREATE TABLE `tbuser` (
  `iduser` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbuser`
--

INSERT INTO `tbuser` (`iduser`, `nama`, `username`, `password`) VALUES
(1, 'admin', 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbbarang`
--
ALTER TABLE `tbbarang`
  ADD PRIMARY KEY (`idbarang`);

--
-- Indeks untuk tabel `tbpengeluaran`
--
ALTER TABLE `tbpengeluaran`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD PRIMARY KEY (`idtransaksi`);

--
-- Indeks untuk tabel `tbuser`
--
ALTER TABLE `tbuser`
  ADD PRIMARY KEY (`iduser`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbbarang`
--
ALTER TABLE `tbbarang`
  MODIFY `idbarang` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `tbpengeluaran`
--
ALTER TABLE `tbpengeluaran`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  MODIFY `idtransaksi` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT untuk tabel `tbuser`
--
ALTER TABLE `tbuser`
  MODIFY `iduser` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
