--
-- PostgreSQL database dump
--

-- Dumped from database version 13.2
-- Dumped by pg_dump version 13.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: hitungefektif(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.hitungefektif() RETURNS trigger
    LANGUAGE plpgsql
    AS $$



	begin 



		if new.saldopinjam <= 0 and new.flagpinjam = 0 then 



				update tblpinjam set saldopinjam = 0, flagpinjam = 1



				where idpinjam = new.idpinjam;



		else 



			if old.jenis = 'EFEKTIF' then



				update tblpinjam set angsuranbunga = ceil (saldopinjam * persenbunga / 100)



				where idpinjam = new.idpinjam;



			elseif old.jenis = 'ANUITAS' then



				update tblpinjam set angsuranbunga =  ceil(saldopinjam * persenbunga / 100) , angsuranpokok = ceil(jumlahangsuran - ceil(saldopinjam * persenbunga / 100))



				where idpinjam = new.idpinjam;



			end if;



		



		update tblpinjam set jumlahangsuran = angsuranbunga + angsuranpokok where idpinjam = new.idpinjam ;



		end if;







	return new;



	end;



	$$;


ALTER FUNCTION public.hitungefektif() OWNER TO postgres;

--
-- Name: setflagaktif(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.setflagaktif() RETURNS trigger
    LANGUAGE plpgsql
    AS $$



begin 



		if new.besarbayar = old.totalangsur then 



			update tbltagihan set flagtagihan = 1 where idtagihan = new.idtagihan;



		elseif old.flagtagihan = 1 and new.besarbayar < old.totalangsur then



			update tbltagihan set flagtagihan = 0 where idtagihan = new.idtagihan;



		end if;



		return new;



end;



$$;


ALTER FUNCTION public.setflagaktif() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: paste_errors; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.paste_errors (
    f1 character varying(255),
    f2 character varying(255),
    f3 character varying(255),
    f4 character varying(255),
    f5 character varying(255),
    f6 character varying(255),
    f7 character varying(255),
    f8 character varying(255),
    f9 character varying(255),
    f10 character varying(255),
    f11 character varying(255),
    f12 character varying(255),
    f13 character varying(255),
    f14 character varying(255),
    f15 double precision,
    f16 double precision,
    f17 double precision,
    trial822 character(1)
);


ALTER TABLE public.paste_errors OWNER TO postgres;

--
-- Name: TABLE paste_errors; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.paste_errors IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f1; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f1 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f2; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f2 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f3; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f3 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f4; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f4 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f5; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f5 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f6; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f6 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f7; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f7 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f8; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f8 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f9; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f9 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f10; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f10 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f11; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f11 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f12; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f12 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f13; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f13 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f14; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f14 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f15; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f15 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f16; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f16 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.f17; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.f17 IS 'TRIAL';


--
-- Name: COLUMN paste_errors.trial822; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.paste_errors.trial822 IS 'TRIAL';


--
-- Name: tblgroup; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblgroup (
    dgroup character varying(30) NOT NULL,
    keterangan character varying(50),
    trial825 character(1)
);


ALTER TABLE public.tblgroup OWNER TO postgres;

--
-- Name: TABLE tblgroup; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblgroup IS 'TRIAL';


--
-- Name: COLUMN tblgroup.dgroup; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblgroup.dgroup IS 'TRIAL';


--
-- Name: COLUMN tblgroup.keterangan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblgroup.keterangan IS 'TRIAL';


--
-- Name: COLUMN tblgroup.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblgroup.trial825 IS 'TRIAL';


--
-- Name: tblmenu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblmenu (
    idmenu integer NOT NULL,
    dgroup character varying(30),
    menucaption character varying(50),
    menutag integer DEFAULT 0,
    menulevel integer DEFAULT 0,
    flag boolean DEFAULT true NOT NULL,
    trial825 character(1)
);


ALTER TABLE public.tblmenu OWNER TO postgres;

--
-- Name: TABLE tblmenu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblmenu IS 'TRIAL';


--
-- Name: COLUMN tblmenu.idmenu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblmenu.idmenu IS 'TRIAL';


--
-- Name: COLUMN tblmenu.dgroup; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblmenu.dgroup IS 'TRIAL';


--
-- Name: COLUMN tblmenu.menucaption; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblmenu.menucaption IS 'TRIAL';


--
-- Name: COLUMN tblmenu.menutag; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblmenu.menutag IS 'TRIAL';


--
-- Name: COLUMN tblmenu.menulevel; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblmenu.menulevel IS 'TRIAL';


--
-- Name: COLUMN tblmenu.flag; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblmenu.flag IS 'TRIAL';


--
-- Name: COLUMN tblmenu.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblmenu.trial825 IS 'TRIAL';


--
-- Name: tbluser; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbluser (
    iduser character varying(17) NOT NULL,
    duser character varying(30),
    dpassword character varying(15),
    namalengkap character varying(50),
    dgroup character varying(30),
    trial828 character(1)
);


ALTER TABLE public.tbluser OWNER TO postgres;

--
-- Name: TABLE tbluser; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tbluser IS 'TRIAL';


--
-- Name: COLUMN tbluser.iduser; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbluser.iduser IS 'TRIAL';


--
-- Name: COLUMN tbluser.duser; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbluser.duser IS 'TRIAL';


--
-- Name: COLUMN tbluser.dpassword; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbluser.dpassword IS 'TRIAL';


--
-- Name: COLUMN tbluser.namalengkap; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbluser.namalengkap IS 'TRIAL';


--
-- Name: COLUMN tbluser.dgroup; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbluser.dgroup IS 'TRIAL';


--
-- Name: COLUMN tbluser.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbluser.trial828 IS 'TRIAL';


--
-- Name: qmenu; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qmenu AS
 SELECT tblmenu.idmenu,
    tblmenu.dgroup,
    tblmenu.menucaption,
    tblmenu.menutag,
    tblmenu.menulevel,
    tblmenu.flag,
    tblgroup.keterangan,
    tbluser.iduser,
    tbluser.duser,
    tbluser.dpassword,
    tbluser.namalengkap
   FROM ((public.tblgroup
     JOIN public.tbluser ON (((tblgroup.dgroup)::text = (tbluser.dgroup)::text)))
     JOIN public.tblmenu ON (((tblgroup.dgroup)::text = (tblmenu.dgroup)::text)));


ALTER TABLE public.qmenu OWNER TO postgres;

--
-- Name: tblakun; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblakun (
    idakun character varying(255) NOT NULL,
    akun character varying(200),
    nomer character varying(50),
    deskripsi character varying(200),
    kategori character varying(200),
    pajak double precision,
    saldo double precision DEFAULT 0,
    flag integer DEFAULT 0,
    ketpajak character varying(200),
    h1 integer DEFAULT 0,
    h2 integer DEFAULT 0,
    h3 character varying(255),
    nourut integer DEFAULT 0,
    trial822 character(1)
);


ALTER TABLE public.tblakun OWNER TO postgres;

--
-- Name: TABLE tblakun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblakun IS 'TRIAL';


--
-- Name: COLUMN tblakun.idakun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.idakun IS 'TRIAL';


--
-- Name: COLUMN tblakun.akun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.akun IS 'TRIAL';


--
-- Name: COLUMN tblakun.nomer; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.nomer IS 'TRIAL';


--
-- Name: COLUMN tblakun.deskripsi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.deskripsi IS 'TRIAL';


--
-- Name: COLUMN tblakun.kategori; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.kategori IS 'TRIAL';


--
-- Name: COLUMN tblakun.pajak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.pajak IS 'TRIAL';


--
-- Name: COLUMN tblakun.saldo; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.saldo IS 'TRIAL';


--
-- Name: COLUMN tblakun.flag; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.flag IS 'TRIAL';


--
-- Name: COLUMN tblakun.ketpajak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.ketpajak IS 'TRIAL';


--
-- Name: COLUMN tblakun.h1; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.h1 IS 'TRIAL';


--
-- Name: COLUMN tblakun.h2; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.h2 IS 'TRIAL';


--
-- Name: COLUMN tblakun.h3; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.h3 IS 'TRIAL';


--
-- Name: COLUMN tblakun.nourut; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.nourut IS 'TRIAL';


--
-- Name: COLUMN tblakun.trial822; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblakun.trial822 IS 'TRIAL';


--
-- Name: tblkontak; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblkontak (
    idkontak character varying(255) NOT NULL,
    kodekontak character varying(50),
    kelompok character varying(50),
    namakontak character varying(200),
    perusahaan character varying(100),
    alamat character varying(250),
    telp character varying(50),
    email character varying(200),
    web character varying(150),
    saldokontak numeric(20,0),
    trial825 character(1)
);


ALTER TABLE public.tblkontak OWNER TO postgres;

--
-- Name: TABLE tblkontak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblkontak IS 'TRIAL';


--
-- Name: COLUMN tblkontak.idkontak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.idkontak IS 'TRIAL';


--
-- Name: COLUMN tblkontak.kodekontak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.kodekontak IS 'TRIAL';


--
-- Name: COLUMN tblkontak.kelompok; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.kelompok IS 'TRIAL';


--
-- Name: COLUMN tblkontak.namakontak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.namakontak IS 'TRIAL';


--
-- Name: COLUMN tblkontak.perusahaan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.perusahaan IS 'TRIAL';


--
-- Name: COLUMN tblkontak.alamat; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.alamat IS 'TRIAL';


--
-- Name: COLUMN tblkontak.telp; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.telp IS 'TRIAL';


--
-- Name: COLUMN tblkontak.email; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.email IS 'TRIAL';


--
-- Name: COLUMN tblkontak.web; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.web IS 'TRIAL';


--
-- Name: COLUMN tblkontak.saldokontak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.saldokontak IS 'TRIAL';


--
-- Name: COLUMN tblkontak.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkontak.trial825 IS 'TRIAL';


--
-- Name: tblneraca; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblneraca (
    idneraca character varying(255) NOT NULL,
    idakun character varying(255),
    idperiode character varying(50),
    debet double precision DEFAULT 0,
    kredit double precision DEFAULT 0,
    tanggal timestamp without time zone,
    ketneraca character varying(100),
    fakturneraca character varying(50),
    kelompok character varying(50),
    akunasal character varying(100),
    akuntujuan character varying(100),
    useradd character varying(100),
    tgl integer DEFAULT 0,
    bln integer DEFAULT 0,
    thn integer DEFAULT 0,
    urutan integer DEFAULT 0,
    flagneraca integer DEFAULT 0,
    saldoakun double precision DEFAULT 0,
    penerima character varying(255),
    terbilang character varying(255),
    keterangan character varying(255),
    ceknomer character varying(255),
    idpenerima character varying(255),
    bukti character varying(255),
    notransaksi integer DEFAULT 0,
    trial825 character(1)
);


ALTER TABLE public.tblneraca OWNER TO postgres;

--
-- Name: TABLE tblneraca; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblneraca IS 'TRIAL';


--
-- Name: COLUMN tblneraca.idneraca; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.idneraca IS 'TRIAL';


--
-- Name: COLUMN tblneraca.idakun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.idakun IS 'TRIAL';


--
-- Name: COLUMN tblneraca.idperiode; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.idperiode IS 'TRIAL';


--
-- Name: COLUMN tblneraca.debet; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.debet IS 'TRIAL';


--
-- Name: COLUMN tblneraca.kredit; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.kredit IS 'TRIAL';


--
-- Name: COLUMN tblneraca.tanggal; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.tanggal IS 'TRIAL';


--
-- Name: COLUMN tblneraca.ketneraca; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.ketneraca IS 'TRIAL';


--
-- Name: COLUMN tblneraca.fakturneraca; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.fakturneraca IS 'TRIAL';


--
-- Name: COLUMN tblneraca.kelompok; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.kelompok IS 'TRIAL';


--
-- Name: COLUMN tblneraca.akunasal; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.akunasal IS 'TRIAL';


--
-- Name: COLUMN tblneraca.akuntujuan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.akuntujuan IS 'TRIAL';


--
-- Name: COLUMN tblneraca.useradd; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.useradd IS 'TRIAL';


--
-- Name: COLUMN tblneraca.tgl; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.tgl IS 'TRIAL';


--
-- Name: COLUMN tblneraca.bln; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.bln IS 'TRIAL';


--
-- Name: COLUMN tblneraca.thn; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.thn IS 'TRIAL';


--
-- Name: COLUMN tblneraca.urutan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.urutan IS 'TRIAL';


--
-- Name: COLUMN tblneraca.flagneraca; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.flagneraca IS 'TRIAL';


--
-- Name: COLUMN tblneraca.saldoakun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.saldoakun IS 'TRIAL';


--
-- Name: COLUMN tblneraca.penerima; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.penerima IS 'TRIAL';


--
-- Name: COLUMN tblneraca.terbilang; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.terbilang IS 'TRIAL';


--
-- Name: COLUMN tblneraca.keterangan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.keterangan IS 'TRIAL';


--
-- Name: COLUMN tblneraca.ceknomer; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.ceknomer IS 'TRIAL';


--
-- Name: COLUMN tblneraca.idpenerima; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.idpenerima IS 'TRIAL';


--
-- Name: COLUMN tblneraca.bukti; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.bukti IS 'TRIAL';


--
-- Name: COLUMN tblneraca.notransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.notransaksi IS 'TRIAL';


--
-- Name: COLUMN tblneraca.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblneraca.trial825 IS 'TRIAL';


--
-- Name: tblperiode; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblperiode (
    idperiode character varying(50) NOT NULL,
    periode character varying(20),
    status character varying(10),
    urutanperiode integer,
    trial825 character(1)
);


ALTER TABLE public.tblperiode OWNER TO postgres;

--
-- Name: TABLE tblperiode; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblperiode IS 'TRIAL';


--
-- Name: COLUMN tblperiode.idperiode; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblperiode.idperiode IS 'TRIAL';


--
-- Name: COLUMN tblperiode.periode; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblperiode.periode IS 'TRIAL';


--
-- Name: COLUMN tblperiode.status; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblperiode.status IS 'TRIAL';


--
-- Name: COLUMN tblperiode.urutanperiode; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblperiode.urutanperiode IS 'TRIAL';


--
-- Name: COLUMN tblperiode.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblperiode.trial825 IS 'TRIAL';


--
-- Name: qneraca; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qneraca AS
 SELECT tblneraca.idneraca,
    tblneraca.idakun,
    tblneraca.idperiode,
    tblneraca.debet,
    tblneraca.kredit,
    tblneraca.tanggal,
    tblneraca.ketneraca,
    tblneraca.fakturneraca,
    tblneraca.kelompok,
    tblneraca.akunasal,
    tblneraca.akuntujuan,
    tblneraca.useradd,
    tblneraca.tgl,
    tblneraca.bln,
    tblneraca.thn,
    tblneraca.urutan,
    tblneraca.flagneraca,
    tblneraca.saldoakun,
    tblneraca.penerima,
    tblneraca.terbilang,
    tblneraca.keterangan,
    tblneraca.ceknomer,
    tblneraca.idpenerima,
    tblneraca.bukti,
    tblakun.akun,
    tblakun.nomer,
    tblakun.deskripsi,
    tblakun.kategori,
    tblakun.pajak,
    tblakun.saldo,
    tblakun.flag,
    tblakun.ketpajak,
    tblakun.h1,
    tblakun.h2,
    tblakun.h3,
    tblakun.nourut,
    tblperiode.periode,
    tblperiode.status,
    tblperiode.urutanperiode,
    tblneraca.notransaksi,
    tblkontak.kodekontak,
    tblkontak.namakontak,
    tblkontak.perusahaan,
    tblkontak.alamat,
    tblkontak.telp,
    tblkontak.email,
    tblkontak.web,
    tblkontak.saldokontak
   FROM (public.tblakun
     JOIN (public.tblperiode
     JOIN (public.tblkontak
     JOIN public.tblneraca ON (((tblkontak.idkontak)::text = (tblneraca.idpenerima)::text))) ON (((tblperiode.idperiode)::text = (tblneraca.idperiode)::text))) ON (((tblakun.idakun)::text = (tblneraca.idakun)::text)));


ALTER TABLE public.qneraca OWNER TO postgres;

--
-- Name: tblanggota; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblanggota (
    idanggota character varying(30) NOT NULL,
    jenisanggota character varying(50),
    anggota character varying(100),
    jk character varying(1),
    tempatlahir character varying(200),
    tanggallahir timestamp without time zone,
    noktp character varying(50),
    alamat character varying(250),
    notelp character varying(50),
    pekerjaan character varying(50),
    status character varying(50),
    namasaudara character varying(100),
    hpsaudara character varying(100),
    foto bytea,
    tahunmasuk timestamp without time zone,
    statusanggota integer DEFAULT 1,
    fp integer DEFAULT 0,
    trial822 character(1)
);


ALTER TABLE public.tblanggota OWNER TO postgres;

--
-- Name: TABLE tblanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblanggota IS 'TRIAL';


--
-- Name: COLUMN tblanggota.idanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.idanggota IS 'TRIAL';


--
-- Name: COLUMN tblanggota.jenisanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.jenisanggota IS 'TRIAL';


--
-- Name: COLUMN tblanggota.anggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.anggota IS 'TRIAL';


--
-- Name: COLUMN tblanggota.jk; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.jk IS 'TRIAL';


--
-- Name: COLUMN tblanggota.tempatlahir; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.tempatlahir IS 'TRIAL';


--
-- Name: COLUMN tblanggota.tanggallahir; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.tanggallahir IS 'TRIAL';


--
-- Name: COLUMN tblanggota.noktp; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.noktp IS 'TRIAL';


--
-- Name: COLUMN tblanggota.alamat; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.alamat IS 'TRIAL';


--
-- Name: COLUMN tblanggota.notelp; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.notelp IS 'TRIAL';


--
-- Name: COLUMN tblanggota.pekerjaan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.pekerjaan IS 'TRIAL';


--
-- Name: COLUMN tblanggota.status; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.status IS 'TRIAL';


--
-- Name: COLUMN tblanggota.namasaudara; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.namasaudara IS 'TRIAL';


--
-- Name: COLUMN tblanggota.hpsaudara; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.hpsaudara IS 'TRIAL';


--
-- Name: COLUMN tblanggota.foto; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.foto IS 'TRIAL';


--
-- Name: COLUMN tblanggota.tahunmasuk; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.tahunmasuk IS 'TRIAL';


--
-- Name: COLUMN tblanggota.statusanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.statusanggota IS 'TRIAL';


--
-- Name: COLUMN tblanggota.fp; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.fp IS 'TRIAL';


--
-- Name: COLUMN tblanggota.trial822; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblanggota.trial822 IS 'TRIAL';


--
-- Name: tblpinjam; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblpinjam (
    idpinjam character varying(50) NOT NULL,
    idanggota character varying(30),
    jenis character varying(20),
    tglpinjam timestamp without time zone,
    besarpinjam double precision DEFAULT 0,
    lamapinjam integer DEFAULT 0,
    persenbunga double precision DEFAULT 0,
    administrasi double precision DEFAULT 0,
    asuransi double precision DEFAULT 0,
    angsuranpokok double precision DEFAULT 0,
    angsuranbunga double precision DEFAULT 0,
    jumlahangsuran double precision DEFAULT 0,
    diterima double precision DEFAULT 0,
    bayarpokok double precision DEFAULT 0,
    bayarbunga double precision DEFAULT 0,
    saldopinjam double precision DEFAULT 0,
    statuspinjam integer DEFAULT 0,
    flagpinjam integer DEFAULT 0,
    addpinjam character varying(100),
    flagpostingpinjam integer DEFAULT 0,
    flaggenerated smallint DEFAULT 0,
    dendapersen double precision DEFAULT 0
);


ALTER TABLE public.tblpinjam OWNER TO postgres;

--
-- Name: TABLE tblpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblpinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.idpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.idpinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.idanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.idanggota IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.jenis; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.jenis IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.tglpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.tglpinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.besarpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.besarpinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.lamapinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.lamapinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.persenbunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.persenbunga IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.administrasi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.administrasi IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.asuransi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.asuransi IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.angsuranpokok; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.angsuranpokok IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.angsuranbunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.angsuranbunga IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.jumlahangsuran; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.jumlahangsuran IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.diterima; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.diterima IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.bayarpokok; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.bayarpokok IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.bayarbunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.bayarbunga IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.saldopinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.saldopinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.statuspinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.statuspinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.flagpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.flagpinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.addpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.addpinjam IS 'TRIAL';


--
-- Name: COLUMN tblpinjam.flagpostingpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblpinjam.flagpostingpinjam IS 'TRIAL';


--
-- Name: qpinjam; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qpinjam AS
 SELECT tblpinjam.idpinjam,
    tblpinjam.idanggota,
    tblpinjam.jenis,
    tblpinjam.tglpinjam,
    tblpinjam.besarpinjam,
    tblpinjam.lamapinjam,
    tblpinjam.persenbunga,
    tblpinjam.administrasi,
    tblpinjam.asuransi,
    tblpinjam.angsuranpokok,
    tblpinjam.angsuranbunga,
    tblpinjam.jumlahangsuran,
    tblpinjam.diterima,
    tblpinjam.bayarpokok,
    tblpinjam.bayarbunga,
    tblpinjam.saldopinjam,
    tblpinjam.statuspinjam,
    tblpinjam.flagpinjam,
    tblpinjam.addpinjam,
    tblpinjam.flaggenerated,
    tblpinjam.dendapersen,
    tblanggota.jenisanggota,
    tblanggota.anggota,
    tblanggota.jk,
    tblanggota.tempatlahir,
    tblanggota.tanggallahir,
    tblanggota.noktp,
    tblanggota.alamat,
    tblanggota.notelp,
    tblanggota.pekerjaan,
    tblanggota.status,
    tblanggota.namasaudara,
    tblanggota.hpsaudara,
    tblanggota.foto,
    tblanggota.tahunmasuk,
    tblanggota.statusanggota,
    tblpinjam.flagpostingpinjam
   FROM (public.tblanggota
     JOIN public.tblpinjam ON (((tblanggota.idanggota)::text = (tblpinjam.idanggota)::text)));


ALTER TABLE public.qpinjam OWNER TO postgres;

--
-- Name: tblrekap; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblrekap (
    idrekap character varying(50) NOT NULL,
    idpinjam character varying(20),
    pokok double precision DEFAULT 0,
    bunga double precision DEFAULT 0,
    total double precision DEFAULT 0,
    trial828 character(1)
);


ALTER TABLE public.tblrekap OWNER TO postgres;

--
-- Name: TABLE tblrekap; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblrekap IS 'TRIAL';


--
-- Name: COLUMN tblrekap.idrekap; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekap.idrekap IS 'TRIAL';


--
-- Name: COLUMN tblrekap.idpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekap.idpinjam IS 'TRIAL';


--
-- Name: COLUMN tblrekap.pokok; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekap.pokok IS 'TRIAL';


--
-- Name: COLUMN tblrekap.bunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekap.bunga IS 'TRIAL';


--
-- Name: COLUMN tblrekap.total; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekap.total IS 'TRIAL';


--
-- Name: COLUMN tblrekap.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekap.trial828 IS 'TRIAL';


--
-- Name: qrekap; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qrekap AS
 SELECT tblrekap.idrekap,
    tblrekap.idpinjam,
    tblrekap.pokok,
    tblrekap.bunga,
    tblrekap.total,
    qpinjam.idanggota,
    qpinjam.jenis,
    qpinjam.tglpinjam,
    qpinjam.besarpinjam,
    qpinjam.lamapinjam,
    qpinjam.persenbunga,
    qpinjam.administrasi,
    qpinjam.asuransi,
    qpinjam.angsuranpokok,
    qpinjam.angsuranbunga,
    qpinjam.jumlahangsuran,
    qpinjam.diterima,
    qpinjam.bayarpokok,
    qpinjam.bayarbunga,
    qpinjam.saldopinjam,
    qpinjam.statuspinjam,
    qpinjam.flagpinjam,
    qpinjam.addpinjam,
    qpinjam.jenisanggota,
    qpinjam.anggota,
    qpinjam.jk,
    qpinjam.tempatlahir,
    qpinjam.tanggallahir,
    qpinjam.noktp,
    qpinjam.alamat,
    qpinjam.notelp,
    qpinjam.pekerjaan,
    qpinjam.status,
    qpinjam.namasaudara,
    qpinjam.hpsaudara,
    qpinjam.foto,
    qpinjam.tahunmasuk,
    qpinjam.statusanggota
   FROM (public.qpinjam
     JOIN public.tblrekap ON (((qpinjam.idpinjam)::text = (tblrekap.idpinjam)::text)));


ALTER TABLE public.qrekap OWNER TO postgres;

--
-- Name: tblrekapbunga; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblrekapbunga (
    idrekapsuk integer NOT NULL,
    idsukarela integer,
    rekapbunga double precision,
    tglrekap timestamp without time zone,
    trial828 character(1)
);


ALTER TABLE public.tblrekapbunga OWNER TO postgres;

--
-- Name: TABLE tblrekapbunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblrekapbunga IS 'TRIAL';


--
-- Name: COLUMN tblrekapbunga.idrekapsuk; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapbunga.idrekapsuk IS 'TRIAL';


--
-- Name: COLUMN tblrekapbunga.idsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapbunga.idsukarela IS 'TRIAL';


--
-- Name: COLUMN tblrekapbunga.rekapbunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapbunga.rekapbunga IS 'TRIAL';


--
-- Name: COLUMN tblrekapbunga.tglrekap; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapbunga.tglrekap IS 'TRIAL';


--
-- Name: COLUMN tblrekapbunga.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapbunga.trial828 IS 'TRIAL';


--
-- Name: tblsukarela; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblsukarela (
    idsukarela integer NOT NULL,
    idanggota character varying(100),
    tglsukarela timestamp without time zone,
    flagsukarela integer,
    ketsukarela character varying(100),
    bunga double precision,
    kode character varying(10),
    trial828 character(1)
);


ALTER TABLE public.tblsukarela OWNER TO postgres;

--
-- Name: TABLE tblsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblsukarela IS 'TRIAL';


--
-- Name: COLUMN tblsukarela.idsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsukarela.idsukarela IS 'TRIAL';


--
-- Name: COLUMN tblsukarela.idanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsukarela.idanggota IS 'TRIAL';


--
-- Name: COLUMN tblsukarela.tglsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsukarela.tglsukarela IS 'TRIAL';


--
-- Name: COLUMN tblsukarela.flagsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsukarela.flagsukarela IS 'TRIAL';


--
-- Name: COLUMN tblsukarela.ketsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsukarela.ketsukarela IS 'TRIAL';


--
-- Name: COLUMN tblsukarela.bunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsukarela.bunga IS 'TRIAL';


--
-- Name: COLUMN tblsukarela.kode; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsukarela.kode IS 'TRIAL';


--
-- Name: COLUMN tblsukarela.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsukarela.trial828 IS 'TRIAL';


--
-- Name: qrekapbunga; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qrekapbunga AS
 SELECT tblrekapbunga.idrekapsuk,
    tblrekapbunga.idsukarela,
    tblrekapbunga.rekapbunga,
    tblrekapbunga.tglrekap,
    tblsukarela.idanggota,
    tblsukarela.tglsukarela,
    tblsukarela.flagsukarela,
    tblsukarela.ketsukarela,
    tblsukarela.bunga,
    tblsukarela.kode,
    tblanggota.jenisanggota,
    tblanggota.anggota,
    tblanggota.jk,
    tblanggota.tempatlahir,
    tblanggota.tanggallahir,
    tblanggota.noktp,
    tblanggota.alamat,
    tblanggota.notelp,
    tblanggota.pekerjaan,
    tblanggota.status,
    tblanggota.namasaudara,
    tblanggota.hpsaudara,
    tblanggota.foto,
    tblanggota.tahunmasuk,
    tblanggota.statusanggota,
    tblanggota.fp
   FROM ((public.tblanggota
     JOIN public.tblsukarela ON (((tblanggota.idanggota)::text = (tblsukarela.idanggota)::text)))
     JOIN public.tblrekapbunga ON ((tblsukarela.idsukarela = tblrekapbunga.idsukarela)));


ALTER TABLE public.qrekapbunga OWNER TO postgres;

--
-- Name: tblrekapsimp; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblrekapsimp (
    idrekapsimp integer NOT NULL,
    idanggota character varying(100),
    pokok double precision,
    wajib double precision,
    saldoawal double precision,
    total double precision,
    tglrekap timestamp without time zone,
    trial828 character(1)
);


ALTER TABLE public.tblrekapsimp OWNER TO postgres;

--
-- Name: TABLE tblrekapsimp; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblrekapsimp IS 'TRIAL';


--
-- Name: COLUMN tblrekapsimp.idrekapsimp; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsimp.idrekapsimp IS 'TRIAL';


--
-- Name: COLUMN tblrekapsimp.idanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsimp.idanggota IS 'TRIAL';


--
-- Name: COLUMN tblrekapsimp.pokok; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsimp.pokok IS 'TRIAL';


--
-- Name: COLUMN tblrekapsimp.wajib; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsimp.wajib IS 'TRIAL';


--
-- Name: COLUMN tblrekapsimp.saldoawal; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsimp.saldoawal IS 'TRIAL';


--
-- Name: COLUMN tblrekapsimp.total; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsimp.total IS 'TRIAL';


--
-- Name: COLUMN tblrekapsimp.tglrekap; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsimp.tglrekap IS 'TRIAL';


--
-- Name: COLUMN tblrekapsimp.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsimp.trial828 IS 'TRIAL';


--
-- Name: qrekapsimp; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qrekapsimp AS
 SELECT tblrekapsimp.idrekapsimp,
    tblrekapsimp.idanggota,
    tblrekapsimp.pokok,
    tblrekapsimp.wajib,
    tblrekapsimp.saldoawal,
    tblrekapsimp.tglrekap,
    tblanggota.jenisanggota,
    tblanggota.anggota,
    tblanggota.jk,
    tblanggota.tempatlahir,
    tblanggota.tanggallahir,
    tblanggota.noktp,
    tblanggota.alamat,
    tblanggota.notelp,
    tblanggota.pekerjaan,
    tblanggota.status,
    tblanggota.namasaudara,
    tblanggota.hpsaudara,
    tblanggota.foto,
    tblanggota.tahunmasuk,
    tblanggota.statusanggota,
    tblanggota.fp,
    tblrekapsimp.total
   FROM (public.tblanggota
     JOIN public.tblrekapsimp ON (((tblanggota.idanggota)::text = (tblrekapsimp.idanggota)::text)));


ALTER TABLE public.qrekapsimp OWNER TO postgres;

--
-- Name: tblrekapsukarela; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblrekapsukarela (
    idrekapsuk integer NOT NULL,
    idsukarela integer,
    saldorekap double precision,
    tglrekap timestamp without time zone,
    trial828 character(1)
);


ALTER TABLE public.tblrekapsukarela OWNER TO postgres;

--
-- Name: TABLE tblrekapsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblrekapsukarela IS 'TRIAL';


--
-- Name: COLUMN tblrekapsukarela.idrekapsuk; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsukarela.idrekapsuk IS 'TRIAL';


--
-- Name: COLUMN tblrekapsukarela.idsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsukarela.idsukarela IS 'TRIAL';


--
-- Name: COLUMN tblrekapsukarela.saldorekap; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsukarela.saldorekap IS 'TRIAL';


--
-- Name: COLUMN tblrekapsukarela.tglrekap; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsukarela.tglrekap IS 'TRIAL';


--
-- Name: COLUMN tblrekapsukarela.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekapsukarela.trial828 IS 'TRIAL';


--
-- Name: qrekapsukarela; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qrekapsukarela AS
 SELECT tblrekapsukarela.idrekapsuk,
    tblrekapsukarela.idsukarela,
    tblrekapsukarela.tglrekap,
    tblsukarela.idanggota,
    tblsukarela.tglsukarela,
    tblsukarela.flagsukarela,
    tblsukarela.ketsukarela,
    tblsukarela.bunga,
    tblsukarela.kode,
    tblanggota.jenisanggota,
    tblanggota.anggota,
    tblanggota.jk,
    tblanggota.tempatlahir,
    tblanggota.tanggallahir,
    tblanggota.noktp,
    tblanggota.alamat,
    tblanggota.notelp,
    tblanggota.pekerjaan,
    tblanggota.status,
    tblanggota.namasaudara,
    tblanggota.hpsaudara,
    tblanggota.foto,
    tblanggota.tahunmasuk,
    tblanggota.statusanggota,
    tblanggota.fp,
    tblrekapsukarela.saldorekap
   FROM ((public.tblanggota
     JOIN public.tblsukarela ON (((tblanggota.idanggota)::text = (tblsukarela.idanggota)::text)))
     JOIN public.tblrekapsukarela ON ((tblsukarela.idsukarela = tblrekapsukarela.idsukarela)));


ALTER TABLE public.qrekapsukarela OWNER TO postgres;

--
-- Name: tbljenis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbljenis (
    jenissimpanan character varying(50) NOT NULL,
    ketjenis character varying(3),
    bunga double precision DEFAULT 0,
    kategori character varying(30),
    besarsimpanan double precision,
    trial825 character(1)
);


ALTER TABLE public.tbljenis OWNER TO postgres;

--
-- Name: TABLE tbljenis; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tbljenis IS 'TRIAL';


--
-- Name: COLUMN tbljenis.jenissimpanan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbljenis.jenissimpanan IS 'TRIAL';


--
-- Name: COLUMN tbljenis.ketjenis; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbljenis.ketjenis IS 'TRIAL';


--
-- Name: COLUMN tbljenis.bunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbljenis.bunga IS 'TRIAL';


--
-- Name: COLUMN tbljenis.kategori; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbljenis.kategori IS 'TRIAL';


--
-- Name: COLUMN tbljenis.besarsimpanan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbljenis.besarsimpanan IS 'TRIAL';


--
-- Name: COLUMN tbljenis.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbljenis.trial825 IS 'TRIAL';


--
-- Name: tblrekening; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblrekening (
    norek integer NOT NULL,
    idanggota character varying(30),
    jenissimpanan character varying(50),
    besar double precision DEFAULT 0,
    tglrek timestamp without time zone,
    tglbayar timestamp without time zone,
    fbayar integer DEFAULT 0,
    tahun character varying(50),
    ketsimp character varying(100),
    ketkategori character varying(100),
    faktur character varying(20),
    flagrekening integer DEFAULT 0,
    tglambil timestamp without time zone,
    flagpostingrekening integer DEFAULT 0,
    trial828 character(1)
);


ALTER TABLE public.tblrekening OWNER TO postgres;

--
-- Name: TABLE tblrekening; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblrekening IS 'TRIAL';


--
-- Name: COLUMN tblrekening.norek; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.norek IS 'TRIAL';


--
-- Name: COLUMN tblrekening.idanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.idanggota IS 'TRIAL';


--
-- Name: COLUMN tblrekening.jenissimpanan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.jenissimpanan IS 'TRIAL';


--
-- Name: COLUMN tblrekening.besar; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.besar IS 'TRIAL';


--
-- Name: COLUMN tblrekening.tglrek; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.tglrek IS 'TRIAL';


--
-- Name: COLUMN tblrekening.tglbayar; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.tglbayar IS 'TRIAL';


--
-- Name: COLUMN tblrekening.fbayar; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.fbayar IS 'TRIAL';


--
-- Name: COLUMN tblrekening.tahun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.tahun IS 'TRIAL';


--
-- Name: COLUMN tblrekening.ketsimp; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.ketsimp IS 'TRIAL';


--
-- Name: COLUMN tblrekening.ketkategori; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.ketkategori IS 'TRIAL';


--
-- Name: COLUMN tblrekening.faktur; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.faktur IS 'TRIAL';


--
-- Name: COLUMN tblrekening.flagrekening; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.flagrekening IS 'TRIAL';


--
-- Name: COLUMN tblrekening.tglambil; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.tglambil IS 'TRIAL';


--
-- Name: COLUMN tblrekening.flagpostingrekening; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.flagpostingrekening IS 'TRIAL';


--
-- Name: COLUMN tblrekening.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblrekening.trial828 IS 'TRIAL';


--
-- Name: tbltahun; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbltahun (
    tahun character varying(50) NOT NULL,
    flagaktif character varying(10)
);


ALTER TABLE public.tbltahun OWNER TO postgres;

--
-- Name: TABLE tbltahun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tbltahun IS 'TRIAL';


--
-- Name: COLUMN tbltahun.tahun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltahun.tahun IS 'TRIAL';


--
-- Name: COLUMN tbltahun.flagaktif; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltahun.flagaktif IS 'TRIAL';


--
-- Name: qrekening; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qrekening AS
 SELECT tblrekening.norek,
    tblrekening.idanggota,
    tblrekening.jenissimpanan,
    tblrekening.besar,
    tblrekening.tglrek,
    tblrekening.tglbayar,
    tblrekening.fbayar,
    tblrekening.tahun,
    tblrekening.ketsimp,
    tbljenis.kategori,
    tbltahun.flagaktif,
    tblanggota.jenisanggota,
    tblanggota.anggota,
    tblanggota.jk,
    tblanggota.tempatlahir,
    tblanggota.tanggallahir,
    tblanggota.noktp,
    tblanggota.alamat,
    tblanggota.notelp,
    tblanggota.pekerjaan,
    tblanggota.status,
    tblanggota.namasaudara,
    tblanggota.hpsaudara,
    tblanggota.foto,
    tblanggota.tahunmasuk,
    tblanggota.statusanggota,
    tblanggota.fp,
    tblrekening.faktur,
    tblrekening.flagrekening,
    tblrekening.tglambil,
    tblrekening.flagpostingrekening
   FROM (public.tbljenis
     JOIN (public.tblanggota
     JOIN (public.tbltahun
     JOIN public.tblrekening ON (((tbltahun.tahun)::text = (tblrekening.tahun)::text))) ON (((tblanggota.idanggota)::text = (tblrekening.idanggota)::text))) ON (((tbljenis.jenissimpanan)::text = (tblrekening.jenissimpanan)::text)));


ALTER TABLE public.qrekening OWNER TO postgres;

--
-- Name: tblshu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblshu (
    idshu integer NOT NULL,
    idanggota character varying(100),
    tahunshu character varying(50),
    shu double precision DEFAULT 0,
    totalsimpanan double precision DEFAULT 0,
    totalshu double precision,
    trial828 character(1)
);


ALTER TABLE public.tblshu OWNER TO postgres;

--
-- Name: TABLE tblshu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblshu IS 'TRIAL';


--
-- Name: COLUMN tblshu.idshu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblshu.idshu IS 'TRIAL';


--
-- Name: COLUMN tblshu.idanggota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblshu.idanggota IS 'TRIAL';


--
-- Name: COLUMN tblshu.tahunshu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblshu.tahunshu IS 'TRIAL';


--
-- Name: COLUMN tblshu.shu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblshu.shu IS 'TRIAL';


--
-- Name: COLUMN tblshu.totalsimpanan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblshu.totalsimpanan IS 'TRIAL';


--
-- Name: COLUMN tblshu.totalshu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblshu.totalshu IS 'TRIAL';


--
-- Name: COLUMN tblshu.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblshu.trial828 IS 'TRIAL';


--
-- Name: qshu; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qshu AS
 SELECT tblshu.idshu,
    tblshu.idanggota,
    tblshu.tahunshu,
    tblshu.shu,
    tblshu.totalsimpanan,
    tblanggota.jenisanggota,
    tblanggota.anggota,
    tblanggota.jk,
    tblanggota.tempatlahir,
    tblanggota.tanggallahir,
    tblanggota.noktp,
    tblanggota.alamat,
    tblanggota.notelp,
    tblanggota.pekerjaan,
    tblanggota.status,
    tblanggota.namasaudara,
    tblanggota.hpsaudara,
    tblanggota.foto,
    tblanggota.tahunmasuk,
    tblanggota.statusanggota,
    tblanggota.fp,
    tblshu.totalshu
   FROM (public.tblanggota
     JOIN public.tblshu ON (((tblanggota.idanggota)::text = (tblshu.idanggota)::text)));


ALTER TABLE public.qshu OWNER TO postgres;

--
-- Name: tblsisa; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblsisa (
    idsisa integer NOT NULL,
    idpinjam character varying(20),
    pinjam double precision DEFAULT 0,
    bayar double precision DEFAULT 0,
    trial828 character(1)
);


ALTER TABLE public.tblsisa OWNER TO postgres;

--
-- Name: TABLE tblsisa; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblsisa IS 'TRIAL';


--
-- Name: COLUMN tblsisa.idsisa; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsisa.idsisa IS 'TRIAL';


--
-- Name: COLUMN tblsisa.idpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsisa.idpinjam IS 'TRIAL';


--
-- Name: COLUMN tblsisa.pinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsisa.pinjam IS 'TRIAL';


--
-- Name: COLUMN tblsisa.bayar; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsisa.bayar IS 'TRIAL';


--
-- Name: COLUMN tblsisa.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblsisa.trial828 IS 'TRIAL';


--
-- Name: qsisa; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qsisa AS
 SELECT tblsisa.idsisa,
    tblsisa.idpinjam,
    tblsisa.pinjam,
    tblsisa.bayar,
    qpinjam.idanggota,
    qpinjam.jenis,
    qpinjam.tglpinjam,
    qpinjam.besarpinjam,
    qpinjam.lamapinjam,
    qpinjam.persenbunga,
    qpinjam.administrasi,
    qpinjam.asuransi,
    qpinjam.angsuranpokok,
    qpinjam.angsuranbunga,
    qpinjam.jumlahangsuran,
    qpinjam.diterima,
    qpinjam.bayarpokok,
    qpinjam.bayarbunga,
    qpinjam.saldopinjam,
    qpinjam.statuspinjam,
    qpinjam.flagpinjam,
    qpinjam.addpinjam,
    qpinjam.jenisanggota,
    qpinjam.anggota,
    qpinjam.jk,
    qpinjam.tempatlahir,
    qpinjam.tanggallahir,
    qpinjam.noktp,
    qpinjam.alamat,
    qpinjam.notelp,
    qpinjam.pekerjaan,
    qpinjam.status,
    qpinjam.namasaudara,
    qpinjam.hpsaudara,
    qpinjam.foto,
    qpinjam.tahunmasuk,
    qpinjam.statusanggota
   FROM (public.qpinjam
     JOIN public.tblsisa ON (((qpinjam.idpinjam)::text = (tblsisa.idpinjam)::text)));


ALTER TABLE public.qsisa OWNER TO postgres;

--
-- Name: qsukarela; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qsukarela AS
 SELECT tblsukarela.idsukarela,
    tblsukarela.idanggota,
    tblsukarela.tglsukarela,
    tblsukarela.flagsukarela,
    tblsukarela.ketsukarela,
    tblanggota.jenisanggota,
    tblanggota.anggota,
    tblanggota.jk,
    tblanggota.tempatlahir,
    tblanggota.tanggallahir,
    tblanggota.noktp,
    tblanggota.alamat,
    tblanggota.notelp,
    tblanggota.pekerjaan,
    tblanggota.status,
    tblanggota.namasaudara,
    tblanggota.hpsaudara,
    tblanggota.foto,
    tblanggota.tahunmasuk,
    tblanggota.statusanggota,
    tblanggota.fp,
    tblsukarela.bunga,
    tblsukarela.kode
   FROM (public.tblanggota
     JOIN public.tblsukarela ON (((tblanggota.idanggota)::text = (tblsukarela.idanggota)::text)));


ALTER TABLE public.qsukarela OWNER TO postgres;

--
-- Name: tbltagihan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbltagihan (
    idtagihan character varying(20) NOT NULL,
    idpinjam character varying(17),
    tgltagihan timestamp without time zone,
    tglbayar timestamp without time zone,
    besarbayar double precision DEFAULT 0,
    besarpokok double precision DEFAULT 0,
    besarbunga double precision DEFAULT 0,
    totalpokok double precision DEFAULT 0,
    totalangsur double precision DEFAULT 0,
    totalbunga double precision DEFAULT 0,
    cicilanke integer DEFAULT 0,
    flagtagihan integer DEFAULT 0,
    kodetagihan character varying(20),
    addtagihan character varying(150),
    flagpostingtagihan integer DEFAULT 0,
    denda double precision DEFAULT 0
);


ALTER TABLE public.tbltagihan OWNER TO postgres;

--
-- Name: TABLE tbltagihan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tbltagihan IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.idtagihan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.idtagihan IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.idpinjam; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.idpinjam IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.tgltagihan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.tgltagihan IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.tglbayar; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.tglbayar IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.besarbayar; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.besarbayar IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.besarpokok; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.besarpokok IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.besarbunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.besarbunga IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.totalpokok; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.totalpokok IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.totalangsur; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.totalangsur IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.totalbunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.totalbunga IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.cicilanke; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.cicilanke IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.flagtagihan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.flagtagihan IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.kodetagihan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.kodetagihan IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.addtagihan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.addtagihan IS 'TRIAL';


--
-- Name: COLUMN tbltagihan.flagpostingtagihan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltagihan.flagpostingtagihan IS 'TRIAL';


--
-- Name: qtagihan; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qtagihan AS
 SELECT tbltagihan.idtagihan,
    tbltagihan.idpinjam,
    tbltagihan.tgltagihan,
    tbltagihan.tglbayar,
    tbltagihan.besarbayar,
    tbltagihan.besarpokok,
    tbltagihan.besarbunga,
    tbltagihan.totalpokok,
    tbltagihan.totalangsur,
    tbltagihan.totalbunga,
    tbltagihan.cicilanke,
    tbltagihan.flagtagihan,
    tbltagihan.kodetagihan,
    tbltagihan.addtagihan,
    tbltagihan.flagpostingtagihan,
    tbltagihan.denda,
    qpinjam.idanggota,
    qpinjam.jenis,
    qpinjam.tglpinjam,
    qpinjam.besarpinjam,
    qpinjam.lamapinjam,
    qpinjam.persenbunga,
    qpinjam.administrasi,
    qpinjam.asuransi,
    qpinjam.angsuranpokok,
    qpinjam.angsuranbunga,
    qpinjam.jumlahangsuran,
    qpinjam.diterima,
    qpinjam.bayarpokok,
    qpinjam.bayarbunga,
    qpinjam.saldopinjam,
    qpinjam.statuspinjam,
    qpinjam.flagpinjam,
    qpinjam.addpinjam,
    qpinjam.jenisanggota,
    qpinjam.anggota,
    qpinjam.jk,
    qpinjam.tempatlahir,
    qpinjam.tanggallahir,
    qpinjam.noktp,
    qpinjam.alamat,
    qpinjam.notelp,
    qpinjam.pekerjaan,
    qpinjam.status,
    qpinjam.namasaudara,
    qpinjam.hpsaudara,
    qpinjam.foto,
    qpinjam.tahunmasuk,
    qpinjam.statusanggota,
    qpinjam.flagpostingpinjam,
    qpinjam.dendapersen,
    qpinjam.flaggenerated
   FROM (public.qpinjam
     JOIN public.tbltagihan ON (((qpinjam.idpinjam)::text = (tbltagihan.idpinjam)::text)));


ALTER TABLE public.qtagihan OWNER TO postgres;

--
-- Name: tbltransaksi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbltransaksi (
    idtransaksi integer NOT NULL,
    fakturtransaksi character varying(20),
    idsukarela integer DEFAULT 0,
    debet double precision DEFAULT 0,
    kredit double precision DEFAULT 0,
    tgltransaksi timestamp without time zone,
    kettransaksi character varying(50),
    fb integer DEFAULT 0,
    nocetak integer DEFAULT 0,
    useradd character varying(50),
    saldo double precision DEFAULT 0,
    ketkode character varying(10),
    flagpostingtransaksi integer DEFAULT 0,
    trial828 character(1)
);


ALTER TABLE public.tbltransaksi OWNER TO postgres;

--
-- Name: TABLE tbltransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tbltransaksi IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.idtransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.idtransaksi IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.fakturtransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.fakturtransaksi IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.idsukarela; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.idsukarela IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.debet; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.debet IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.kredit; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.kredit IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.tgltransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.tgltransaksi IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.kettransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.kettransaksi IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.fb; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.fb IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.nocetak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.nocetak IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.useradd; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.useradd IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.saldo; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.saldo IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.ketkode; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.ketkode IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.flagpostingtransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.flagpostingtransaksi IS 'TRIAL';


--
-- Name: COLUMN tbltransaksi.trial828; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbltransaksi.trial828 IS 'TRIAL';


--
-- Name: qtransaksi; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.qtransaksi AS
 SELECT tbltransaksi.idtransaksi,
    tbltransaksi.fakturtransaksi,
    tbltransaksi.idsukarela,
    tbltransaksi.debet,
    tbltransaksi.kredit,
    tbltransaksi.tgltransaksi,
    tbltransaksi.kettransaksi,
    tbltransaksi.fb,
    tbltransaksi.nocetak,
    tbltransaksi.useradd,
    tbltransaksi.saldo,
    tblsukarela.idanggota,
    tblsukarela.tglsukarela,
    tblsukarela.flagsukarela,
    tblsukarela.ketsukarela,
    tblanggota.jenisanggota,
    tblanggota.anggota,
    tblanggota.jk,
    tblanggota.tempatlahir,
    tblanggota.tanggallahir,
    tblanggota.noktp,
    tblanggota.alamat,
    tblanggota.notelp,
    tblanggota.pekerjaan,
    tblanggota.status,
    tblanggota.namasaudara,
    tblanggota.hpsaudara,
    tblanggota.foto,
    tblanggota.tahunmasuk,
    tblanggota.statusanggota,
    tblanggota.fp,
    tblsukarela.bunga,
    tblsukarela.kode,
    tbltransaksi.ketkode,
    tbltransaksi.flagpostingtransaksi
   FROM ((public.tblanggota
     JOIN public.tblsukarela ON (((tblanggota.idanggota)::text = (tblsukarela.idanggota)::text)))
     JOIN public.tbltransaksi ON ((tblsukarela.idsukarela = tbltransaksi.idsukarela)));


ALTER TABLE public.qtransaksi OWNER TO postgres;

--
-- Name: tblbunga; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblbunga (
    idtransaksi character varying(255) NOT NULL,
    fakturtransaksi character varying(20),
    norek character varying(10),
    tgltransaksi timestamp without time zone,
    bunga double precision DEFAULT 0,
    fb integer DEFAULT 1,
    useradd character varying(50),
    trial825 character(1)
);


ALTER TABLE public.tblbunga OWNER TO postgres;

--
-- Name: TABLE tblbunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblbunga IS 'TRIAL';


--
-- Name: COLUMN tblbunga.idtransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblbunga.idtransaksi IS 'TRIAL';


--
-- Name: COLUMN tblbunga.fakturtransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblbunga.fakturtransaksi IS 'TRIAL';


--
-- Name: COLUMN tblbunga.norek; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblbunga.norek IS 'TRIAL';


--
-- Name: COLUMN tblbunga.tgltransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblbunga.tgltransaksi IS 'TRIAL';


--
-- Name: COLUMN tblbunga.bunga; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblbunga.bunga IS 'TRIAL';


--
-- Name: COLUMN tblbunga.fb; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblbunga.fb IS 'TRIAL';


--
-- Name: COLUMN tblbunga.useradd; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblbunga.useradd IS 'TRIAL';


--
-- Name: COLUMN tblbunga.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblbunga.trial825 IS 'TRIAL';


--
-- Name: tblidentitas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblidentitas (
    namakoperasi character varying(50) NOT NULL,
    alamatkoperasi character varying(200),
    namainstansi character varying(50),
    kota character varying(50),
    pimpinan character varying(50),
    bagkeuangan character varying(50),
    bendahara character varying(50),
    notelp character varying(255),
    logo bytea,
    idkoperasi integer NOT NULL,
    nama character varying,
    umur character varying,
    alamat character varying,
    pekerjaan character varying,
    noktp character varying,
    toleransi integer DEFAULT 2
);


ALTER TABLE public.tblidentitas OWNER TO postgres;

--
-- Name: TABLE tblidentitas; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblidentitas IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.namakoperasi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.namakoperasi IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.alamatkoperasi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.alamatkoperasi IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.namainstansi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.namainstansi IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.kota; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.kota IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.pimpinan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.pimpinan IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.bagkeuangan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.bagkeuangan IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.bendahara; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.bendahara IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.notelp; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.notelp IS 'TRIAL';


--
-- Name: COLUMN tblidentitas.logo; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblidentitas.logo IS 'TRIAL';


--
-- Name: tbljaminankendaraan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbljaminankendaraan (
    idjaminankendaraan integer NOT NULL,
    jeniskendaraan character varying,
    nopol character varying(20),
    merk character varying,
    nobpkb character varying,
    nomesin character varying,
    norangka character varying,
    tglstnk date,
    warna character varying,
    besarcc character varying,
    tahunbuat character varying,
    pemilik character varying,
    alamatpemilik character varying,
    maxkredit double precision,
    idpinjam character varying
);


ALTER TABLE public.tbljaminankendaraan OWNER TO postgres;

--
-- Name: tbljaminankendaraan_idjaminankendaraan_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbljaminankendaraan ALTER COLUMN idjaminankendaraan ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.tbljaminankendaraan_idjaminankendaraan_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tbljaminanshm; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbljaminanshm (
    idjaminanshm integer NOT NULL,
    noshm character varying,
    atasnama character varying,
    saksi1 character varying,
    saksi2 character varying,
    saksi3 character varying,
    hari character varying,
    idpinjam character varying
);


ALTER TABLE public.tbljaminanshm OWNER TO postgres;

--
-- Name: tbljaminanshm_idjaminanshm_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbljaminanshm ALTER COLUMN idjaminanshm ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.tbljaminanshm_idjaminanshm_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tblkeuangan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblkeuangan (
    idtransaksi integer NOT NULL,
    tgltransaksi timestamp without time zone,
    fakturtransaksi character varying(50),
    masuk double precision DEFAULT 0,
    keluar double precision DEFAULT 0,
    saldo double precision DEFAULT 0,
    keterangan character varying(200),
    tambahan character varying(255),
    notransaksi integer DEFAULT 0,
    trial825 character(1)
);


ALTER TABLE public.tblkeuangan OWNER TO postgres;

--
-- Name: TABLE tblkeuangan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblkeuangan IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.idtransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.idtransaksi IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.tgltransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.tgltransaksi IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.fakturtransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.fakturtransaksi IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.masuk; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.masuk IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.keluar; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.keluar IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.saldo; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.saldo IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.keterangan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.keterangan IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.tambahan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.tambahan IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.notransaksi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.notransaksi IS 'TRIAL';


--
-- Name: COLUMN tblkeuangan.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblkeuangan.trial825 IS 'TRIAL';


--
-- Name: tblkeuangan_idtransaksi_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblkeuangan_idtransaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblkeuangan_idtransaksi_seq OWNER TO postgres;

--
-- Name: tblkeuangan_idtransaksi_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblkeuangan_idtransaksi_seq OWNED BY public.tblkeuangan.idtransaksi;


--
-- Name: tblklasifikasi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblklasifikasi (
    idklasifikasi integer NOT NULL,
    klasifikasi character varying(100),
    header integer,
    sub integer,
    keterangan character varying(255),
    trial825 character(1)
);


ALTER TABLE public.tblklasifikasi OWNER TO postgres;

--
-- Name: TABLE tblklasifikasi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tblklasifikasi IS 'TRIAL';


--
-- Name: COLUMN tblklasifikasi.idklasifikasi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblklasifikasi.idklasifikasi IS 'TRIAL';


--
-- Name: COLUMN tblklasifikasi.klasifikasi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblklasifikasi.klasifikasi IS 'TRIAL';


--
-- Name: COLUMN tblklasifikasi.header; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblklasifikasi.header IS 'TRIAL';


--
-- Name: COLUMN tblklasifikasi.sub; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblklasifikasi.sub IS 'TRIAL';


--
-- Name: COLUMN tblklasifikasi.keterangan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblklasifikasi.keterangan IS 'TRIAL';


--
-- Name: COLUMN tblklasifikasi.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tblklasifikasi.trial825 IS 'TRIAL';


--
-- Name: tbllaporan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbllaporan (
    idakun character varying(255) NOT NULL,
    akun character varying(200),
    nomer character varying(50),
    deskripsi character varying(200),
    kategori character varying(200),
    pajak double precision,
    saldo double precision DEFAULT 0,
    flag integer DEFAULT 0,
    ketpajak character varying(200),
    h1 integer DEFAULT 0,
    h2 integer DEFAULT 0,
    h3 character varying(255),
    nourut integer DEFAULT 0,
    trial825 character(1)
);


ALTER TABLE public.tbllaporan OWNER TO postgres;

--
-- Name: TABLE tbllaporan; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.tbllaporan IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.idakun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.idakun IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.akun; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.akun IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.nomer; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.nomer IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.deskripsi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.deskripsi IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.kategori; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.kategori IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.pajak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.pajak IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.saldo; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.saldo IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.flag; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.flag IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.ketpajak; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.ketpajak IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.h1; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.h1 IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.h2; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.h2 IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.h3; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.h3 IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.nourut; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.nourut IS 'TRIAL';


--
-- Name: COLUMN tbllaporan.trial825; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.tbllaporan.trial825 IS 'TRIAL';


--
-- Name: tblmenu_idmenu_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblmenu_idmenu_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblmenu_idmenu_seq OWNER TO postgres;

--
-- Name: tblmenu_idmenu_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblmenu_idmenu_seq OWNED BY public.tblmenu.idmenu;


--
-- Name: tblrekapbunga_idrekapsuk_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblrekapbunga_idrekapsuk_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblrekapbunga_idrekapsuk_seq OWNER TO postgres;

--
-- Name: tblrekapbunga_idrekapsuk_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblrekapbunga_idrekapsuk_seq OWNED BY public.tblrekapbunga.idrekapsuk;


--
-- Name: tblrekapsimp_idrekapsimp_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblrekapsimp_idrekapsimp_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblrekapsimp_idrekapsimp_seq OWNER TO postgres;

--
-- Name: tblrekapsimp_idrekapsimp_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblrekapsimp_idrekapsimp_seq OWNED BY public.tblrekapsimp.idrekapsimp;


--
-- Name: tblrekapsukarela_idrekapsuk_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblrekapsukarela_idrekapsuk_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblrekapsukarela_idrekapsuk_seq OWNER TO postgres;

--
-- Name: tblrekapsukarela_idrekapsuk_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblrekapsukarela_idrekapsuk_seq OWNED BY public.tblrekapsukarela.idrekapsuk;


--
-- Name: tblrekening_norek_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblrekening_norek_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblrekening_norek_seq OWNER TO postgres;

--
-- Name: tblrekening_norek_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblrekening_norek_seq OWNED BY public.tblrekening.norek;


--
-- Name: tblshu_idshu_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblshu_idshu_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblshu_idshu_seq OWNER TO postgres;

--
-- Name: tblshu_idshu_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblshu_idshu_seq OWNED BY public.tblshu.idshu;


--
-- Name: tblsisa_idsisa_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblsisa_idsisa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblsisa_idsisa_seq OWNER TO postgres;

--
-- Name: tblsisa_idsisa_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblsisa_idsisa_seq OWNED BY public.tblsisa.idsisa;


--
-- Name: tblsukarela_idsukarela_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblsukarela_idsukarela_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblsukarela_idsukarela_seq OWNER TO postgres;

--
-- Name: tblsukarela_idsukarela_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblsukarela_idsukarela_seq OWNED BY public.tblsukarela.idsukarela;


--
-- Name: tbltransaksi_idtransaksi_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbltransaksi_idtransaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tbltransaksi_idtransaksi_seq OWNER TO postgres;

--
-- Name: tbltransaksi_idtransaksi_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbltransaksi_idtransaksi_seq OWNED BY public.tbltransaksi.idtransaksi;


--
-- Name: tbltransaksi_idtransaksi_seq1; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbltransaksi ALTER COLUMN idtransaksi ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.tbltransaksi_idtransaksi_seq1
    START WITH 5
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tblkeuangan idtransaksi; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblkeuangan ALTER COLUMN idtransaksi SET DEFAULT nextval('public.tblkeuangan_idtransaksi_seq'::regclass);


--
-- Name: tblmenu idmenu; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmenu ALTER COLUMN idmenu SET DEFAULT nextval('public.tblmenu_idmenu_seq'::regclass);


--
-- Name: tblrekapbunga idrekapsuk; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapbunga ALTER COLUMN idrekapsuk SET DEFAULT nextval('public.tblrekapbunga_idrekapsuk_seq'::regclass);


--
-- Name: tblrekapsimp idrekapsimp; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapsimp ALTER COLUMN idrekapsimp SET DEFAULT nextval('public.tblrekapsimp_idrekapsimp_seq'::regclass);


--
-- Name: tblrekapsukarela idrekapsuk; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapsukarela ALTER COLUMN idrekapsuk SET DEFAULT nextval('public.tblrekapsukarela_idrekapsuk_seq'::regclass);


--
-- Name: tblrekening norek; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekening ALTER COLUMN norek SET DEFAULT nextval('public.tblrekening_norek_seq'::regclass);


--
-- Name: tblshu idshu; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblshu ALTER COLUMN idshu SET DEFAULT nextval('public.tblshu_idshu_seq'::regclass);


--
-- Name: tblsisa idsisa; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblsisa ALTER COLUMN idsisa SET DEFAULT nextval('public.tblsisa_idsisa_seq'::regclass);


--
-- Name: tblsukarela idsukarela; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblsukarela ALTER COLUMN idsukarela SET DEFAULT nextval('public.tblsukarela_idsukarela_seq'::regclass);


--
-- Data for Name: paste_errors; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.paste_errors (f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, trial822) FROM stdin;
196504281986011001	UMUM	Guntur Cahyo Purnomo	L	-	28-04-1965	-	Kepala Kantor	-	PNS	Menikah	-	-	\N	2017	1	0	T
196504281986011001	UMUM	Guntur Cahyo Purnomo	L	-	28-04-1965	-	Kepala Kantor	-	PNS	Menikah	-	-	\N	2017	1	0	T
197312291995031001	UMUM	Agus Cahyono	L	-	29-12-1973	-	Kepala Subbagian Umum	-	PNS	Menikah	-	-	\N	2017	1	0	T
196708201989121001	UMUM	Agus Hari Tjahjono	L	-	20-08-1967	-	Kepala Subbagian Umum	-	PNS	Menikah	-	-	\N	2017	1	0	T
197207291992121002	UMUM	Irwan Julianto	L	-	29-07-1972	-	Kepala Seksi Penindakan dan Penyidikan  	-	PNS	Menikah	-	-	\N	2017	1	0	T
196911171990121001	UMUM	Sulistiadi	L	-	17-11-1969	-	Kepala Seksi Penindakan dan Penyidikan  	-	PNS	Menikah	-	-	\N	2017	1	0	T
197211141992121001	UMUM	Bambang Sukoco	L	-	14-11-1972	-	Kepala Seksi Perbendaharaan	-	PNS	Menikah	-	-	\N	2017	1	0	T
197108141992011002	UMUM	Aris Murdiyanto	L	-	14-08-1971	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai I	-	PNS	Menikah	-	-	\N	2017	1	0	T
197102021992011002	UMUM	Ogy Febri Adlha	L	-	02-02-1971	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai II	-	PNS	Menikah	-	-	\N	2017	1	0	T
196010041982031004	UMUM	Teddi Yunaedi	L	-	04-10-1960	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai III  	-	PNS	Menikah	-	-	\N	2017	1	0	T
196706241988101001	UMUM	Bernadus Sutjipto, S.E.	L	-	24-06-1967	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai IV   	-	PNS	Menikah	-	-	\N	2017	1	0	T
196212221983031001	UMUM	Irianta Jayandaru Ario	L	-	22-12-1962	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai V   	-	PNS	Menikah	-	-	\N	2017	1	0	T
196304071983031001	UMUM	Satiya Gunawan, S.I.P.	P	-	07-04-1963	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai V   	-	PNS	Menikah	-	-	\N	2017	1	0	T
196705201991121001	UMUM	M. Eka Juarsa, S.E.	L	-	20-05-1967	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai VI	-	PNS	Menikah	-	-	\N	2017	1	0	T
197101251990121001	UMUM	Pahalatua Agus Hendra S	L	-	25-01-1971	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai VII	-	PNS	Menikah	-	-	\N	2017	1	0	T
196011241980031001	UMUM	Binsar Sinaga, S.H., M.M.	L	-	24-11-1960	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai VIII   	-	PNS	Menikah	-	-	\N	2017	1	0	T
197107291993011001	UMUM	Eko Dian Rivani	L	-	29-07-1971	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai IX	-	PNS	Menikah	-	-	\N	2017	1	0	T
197210081999031002	UMUM	Yoko Rudy Suryono, S.H.	L	-	08-10-1972	-	Kepala Seksi Pelayanan Kepabeanan dan Cukai X	-	PNS	Menikah	-	-	\N	2017	1	0	T
197701062002121002	UMUM	Kusmawan	L	-	08-10-1973	-	Kepala Seksi Penyuluhan dan Layanan Informasi  	-	PNS	Menikah	-	-	\N	2017	1	0	T
196601011988101001	UMUM	Teguh Yanuwiarso	L	-	01-01-1966	-	Kepala Seksi Penyuluhan dan Layanan Informasi  	-	PNS	Menikah	-	-	\N	2017	1	0	T
197704161999031002	UMUM	Taufan Bayuaji	L	-	16-04-1977	-	Kepala Seksi Kepatuhan Internal   	-	PNS	Menikah	-	-	\N	2017	1	0	T
197408061995031001	UMUM	Agus Sutejo, S.E.	L	-	06-08-1974	-	Kepala Seksi Kepatuhan Internal   	-	PNS	Menikah	-	-	\N	2017	1	0	T
196208051982091001	UMUM	Agus Supriyanto, S.H ., M.H.	L	-	05-08-1962	-	Kepala Seksi Pengolahan Data dan Administrasi Dokumen	-	PNS	Menikah	-	-	\N	2017	1	0	T
196402221991031001	UMUM	Fitrian Ismed	L	-	22-02-1964	-	Kepala Urusan Tata Usaha dan Kepegawaian	-	PNS	Menikah	-	-	\N	2017	1	0	T
196212081983032002	UMUM	Doortje Y. Maringka	L	-	08-12-1962	-	Kepala Urusan Keuangan	-	PNS	Menikah	-	-	\N	2017	1	0	T
196212021984021001	UMUM	Iding Rahmat Sidik	L	-	02-12-1962	-	Kepala Urusan Rumah Tangga	-	PNS	Menikah	-	-	\N	2017	1	0	T
197411281997031001 	UMUM	Jufri Sanusi, S.H.	L	-	28-11-1974	-	Kepala Subseksi Penyidikan dan Barang Hasil Penindakan	-	PNS	Menikah	-	-	\N	2017	1	0	T
198212252004121002	UMUM	Budi Riswanto	L	-	25-12-1982	-	Kepala Subseksi Intelijen	-	PNS	Menikah	-	-	\N	2017	1	0	T
197503011996021001	UMUM	Gunar Wiratno	L	-	01-03-1975	-	Kepala Subseksi Penindakan dan Sarana Operasi	-	PNS	Menikah	-	-	\N	2017	1	0	T
197704261997031002	UMUM	Heru Cahyono	L	-	26-04-1977	-	Kepala Subseksi Administrasi Penerimaan dan Jaminan I	-	PNS	Menikah	-	-	\N	2017	1	0	T
198002192001121001	UMUM	Muhamad Hadi Ismanto, S.E., M.M.	L	-	19-02-1980	-	Kepala Subseksi Administrasi Penerimaan dan Jaminan II	-	PNS	Menikah	-	-	\N	2017	1	0	T
198003272000011001	UMUM	Sis Martoyo	L	-	27-03-1980	-	Kepala Subseksi Administrasi Penagihan dan Pengembalian	-	PNS	Menikah	-	-	\N	2017	1	0	T
196112121983031002	UMUM	Iskandar, S.H.	L	-	12-12-1961	-	Kepala Subseksi Hanggar Pabean dan Cukai I	-	PNS	Menikah	-	-	\N	2017	1	0	T
197606221998031002	UMUM	Sutrisno, S.E.	L	-	22-06-1976	-	Kepala Subseksi Hanggar Pabean dan Cukai II	-	PNS	Menikah	-	-	\N	2017	1	0	T
197603301996021001	UMUM	Nino Riano, S.H.	L	-	30-03-1976	-	Kepala Subseksi Hanggar Pabean dan Cukai III	-	PNS	Menikah	-	-	\N	2017	1	0	T
197805011997031001	UMUM	Muh. Rois Sugiantoro, S.E., M.Si	L	-	01-05-1978	-	Kepala Subseksi Hanggar Pabean dan Cukai IV	-	PNS	Menikah	-	-	\N	2017	1	0	T
197607121999031001	UMUM	Hadi Haryadi	L	-	12-07-1976	-	Kepala Subseksi Hanggar Pabean dan Cukai V	-	PNS	Menikah	-	-	\N	2017	1	0	T
197610041998031002	UMUM	Iwan Setiawan	L	-	04-10-1976	-	Kepala Subseksi Hanggar Pabean dan Cukai VI	-	PNS	Menikah	-	-	\N	2017	1	0	T
197709151997031001	UMUM	Yan Surya, S.E., M.Si.	L	-	15-09-1977	-	Kepala Subseksi Hanggar Pabean dan Cukai VII	-	PNS	Menikah	-	-	\N	2017	1	0	T
197612312005011001	UMUM	Bambang Riyadi	L	-	31-12-1976	-	Kepala Subseksi Hanggar Pabean dan Cukai VIII	-	PNS	Menikah	-	-	\N	2017	1	0	T
196310241983031001	UMUM	Mujiono	L	-	24-10-1963	-	Kepala Subseksi Hanggar Pabean dan Cukai IX	-	PNS	Menikah	-	-	\N	2017	1	0	T
196901251990121001	UMUM	Suwandi Muljana, S.E	L	-	25-01-1969	-	Kepala Subseksi Hanggar Pabean dan Cukai X	-	PNS	Menikah	-	-	\N	2017	1	0	T
197703181999031004	UMUM	Didit Lajuardi	L	-	18-03-1977	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
197403251996031001	UMUM	Muhammad Awaluddin	L	-	25-03-1974	-	Kepala Subseksi Hanggar Pabean dan Cukai XI	-	PNS	Menikah	-	-	\N	2017	1	0	T
196210221983031004	UMUM	Arman M.Y., S.E.	L	-	22-10-1962	-	Kepala Subseksi Hanggar Pabean dan Cukai XII	-	PNS	Menikah	-	-	\N	2017	1	0	T
197810251997031001	UMUM	Himawan Setiyo	L	-	25-10-1978	-	Kepala Subseksi Hanggar Pabean dan Cukai XIII	-	PNS	Menikah	-	-	\N	2017	1	0	T
197609141997031001	UMUM	Yuddie Lanandie	L	-	14-09-1976	-	Kepala Subseksi Hanggar Pabean dan Cukai XIV	-	PNS	Menikah	-	-	\N	2017	1	0	T
196204111987031001	UMUM	Marno, S.E.	L	-	11-04-1962	-	Kepala Subseksi Hanggar Pabean dan Cukai XV	-	PNS	Menikah	-	-	\N	2017	1	0	T
197807122000011002	UMUM	Esti Dwi Yulianto	L	-	12-07-1978	-	Kepala Subseksi Hanggar Pabean dan Cukai XVI	-	PNS	Menikah	-	-	\N	2017	1	0	T
196210141984031002	UMUM	Amin Pamuji, S.E.	L	-	14-10-1962	-	Kepala Subseksi Hanggar Pabean dan Cukai XVII	-	PNS	Menikah	-	-	\N	2017	1	0	T
196912071998031001	UMUM	Demianus D., S.E.	L	-	07-12-1969	-	Kepala Subseksi Hanggar Pabean dan Cukai XIX	-	PNS	Menikah	-	-	\N	2017	1	0	T
196312121983031001	UMUM	Jadson Rumpia	L	-	12-12-1963	-	Kepala Subseksi Hanggar Pabean dan Cukai XX	-	PNS	Menikah	-	-	\N	2017	1	0	T
196107051983031033	UMUM	Baihaki	L	-	05-07-1961	-	Kepala Subseksi Hanggar Pabean dan Cukai XXI	-	PNS	Menikah	-	-	\N	2017	1	0	T
196709121987031001	UMUM	Dani Budiaman, S.E., M.Si.	L	-	12-09-1967	-	Kepala Subseksi Hanggar Pabean dan Cukai XXII	-	PNS	Menikah	-	-	\N	2017	1	0	T
196009091983031001	UMUM	Joko Songo	L	-	09-09-1960	-	Kepala Subseksi Hanggar Pabean dan Cukai XXIII	-	PNS	Menikah	-	-	\N	2017	1	0	T
196104241984031001	UMUM	Atang Kuswara	L	-	24-04-1961	-	Kepala Subseksi Hanggar Pabean dan Cukai XXIV	-	PNS	Menikah	-	-	\N	2017	1	0	T
197801071997031001	UMUM	Dwi Kusnadi, S.H.	L	-	07-01-1978	-	Kepala Subseksi Hanggar Pabean dan Cukai XXV	-	PNS	Menikah	-	-	\N	2017	1	0	T
196112011983031002	UMUM	Jalaluddin	L	-	01-12-1961	-	Kepala Subseksi Hanggar Pabean dan Cukai XXVI	-	PNS	Menikah	-	-	\N	2017	1	0	T
197607251997031001	UMUM	Dedi Kusnadi, S.E.	L	-	25-07-1976	-	Kepala Subseksi Hanggar Pabean dan Cukai XXVII	-	PNS	Menikah	-	-	\N	2017	1	0	T
197406141994031002	UMUM	Efan Sandy Akbar	L	-	14-06-1974	-	Kepala Subseksi Hanggar Pabean dan Cukai XXVIII	-	PNS	Menikah	-	-	\N	2017	1	0	T
196307071984031001	UMUM	Jontar Gultom	L	-	07-07-1963	-	Kepala Subseksi Hanggar Pabean dan Cukai XXIX	-	PNS	Menikah	-	-	\N	2017	1	0	T
197702051999031002	UMUM	Teguh Purwono, S.E.	L	-	05-02-1977	-	Kepala Subseksi Hanggar Pabean dan Cukai XXX	-	PNS	Menikah	-	-	\N	2017	1	0	T
197312281994021001	UMUM	Arief Defriza, S.E.	L	-	28-12-1973	-	Kepala Subseksi Hanggar Pabean dan Cukai XXXI	-	PNS	Menikah	-	-	\N	2017	1	0	T
196105141985031002	UMUM	Sukmono	L	-	14-05-1961	-	Kepala Subseksi Hanggar Pabean dan Cukai XXXII	-	PNS	Menikah	-	-	\N	2017	1	0	T
196210131983031002	UMUM	Rusli	L	-	13-10-1962	-	Kepala Subseksi Hanggar Pabean dan Cukai XXXIII	-	PNS	Menikah	-	-	\N	2017	1	0	T
197211221992121002	UMUM	Asep Herdiana Subekti	L	-	22-11-1972	-	Kepala Subseksi Hanggar Pabean dan Cukai XXXIV	-	PNS	Menikah	-	-	\N	2017	1	0	T
197608301997031002	UMUM	Raden Mahisa Agung, S.E.	L	-	30-08-1976	-	Kepala Subseksi Hanggar Pabean dan Cukai XXXV	-	PNS	Menikah	-	-	\N	2017	1	0	T
198008272001121002	UMUM	Widodo, S.E., M.M.	L	-	27-08-1980	-	Kepala Subseksi Layanan Informasi	-	PNS	Menikah	-	-	\N	2017	1	0	T
198512092010121003	UMUM	Rahmat Firdaus	L	-	09-12-1985	-	Kepala Subseksi Penyuluhan	-	PNS	Menikah	-	-	\N	2017	1	0	T
197012081992031002	UMUM	Kuto Sembiring	L	-	08-12-1970	-	Kepala Subseksi Kepatuhan Pelaksanaan Tugas Pelayanan dan Administrasi	-	PNS	Menikah	-	-	\N	2017	1	0	T
197408251997031002	UMUM	Diding Toyibudin	L	-	25-08-1974	-	Kepala Subseksi Kepatuhan Pelaksanaan Tugas dan Pengawasan	-	PNS	Menikah	-	-	\N	2017	1	0	T
196603231992031001	UMUM	Parulian Pardede, S.E.	L	-	23-03-1966	-	Kepala Subseksi Pengolahan Data	-	PNS	Menikah	-	-	\N	2017	1	0	T
196303241983031002	UMUM	Budi Santoso	L	-	24-03-1963	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
198003152003122001	UMUM	Puni Puspita, S.kom	L	-	15-03-1980	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
195911231985031003	UMUM	Gunawan Arif S.	L	-	23-11-1959	-	Pelaksana Administrasi	-	PNS	Menikah	-	-	\N	2017	1	0	T
197012241992031001	UMUM	M. Yunus Agung Setyawan	L	-	24-12-1970	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
196801021990091001	UMUM	Ahmad Dasuki	L	-	02-01-1968	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
196609101992031001	UMUM	Mohammad Idris	L	-	10-09-1966	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
196806061992021001	UMUM	Mastur	L	-	06-06-1968	-	Pelaksana Administrasi	-	PNS	Menikah	-	-	\N	2017	1	0	T
196107031983031002	UMUM	Sumedi	L	-	03-07-1961	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
196108171983031004	UMUM	Agus Susanto	L	-	17-08-1961	-	Pelaksana Administrasi	-	PNS	Menikah	-	-	\N	2017	1	0	T
196102251983091001	UMUM	R. Endang Suprihatin	L	-	25-02-1961	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
196408281987031002	UMUM	Rahman	L	-	28-08-1964	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
197610101997031001	UMUM	Hadi Kurniawan	L	-	10-10-1976	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
196606251999031001	UMUM	Suharno, S.E.	L	-	25-06-1966	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
196401121984031001	UMUM	Ubed Junaedi	L	-	12-01-1964	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
196602021993031001	UMUM	Slamet Priyono	L	-	02-02-1966	-	Pelaksana Administrasi	-	PNS	Menikah	-	-	\N	2017	1	0	T
198112222001121001	UMUM	Ismail	L	-	22-12-1981	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
198308092003121005	UMUM	Firmansyah Hadi Winata	L	-	09-08-1983	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199002262012101002	UMUM	Rendy Yusuf Febrianto	L	-	26-02-1990	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
198507032004121002	UMUM	Melkia Sinar Jonlister Sianturi	L	-	03-07-1985	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
198605032006021003	UMUM	I Putu Permana Putra	L	-	03-05-1986	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
198611142007011002	UMUM	Noviarmansyah	L	-	14-11-1986	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199102042010121001	UMUM	Heri Febrianto	L	-	04-02-1991	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
198912042010011001	UMUM	Achzar Abiga Griori	L	-	04-12-1989	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199011102010011001	UMUM	Resha Fahlepi	L	-	10-11-1990	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199002062010011003	UMUM	Hadi Nurhayadi	L	-	06-02-1990	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199208182012101002	UMUM	Josua Agustinus Sinurat	L	-	18-08-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199204102012101002	UMUM	Muttik Udin	L	-	10-04-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199212302012101002	UMUM	Dimas Dian Oscarahadi	L	-	30-12-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199204012012101002	UMUM	Hafiz Ahmad	L	-	01-04-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199208082012101002	UMUM	Riko Prayogi Sularso	L	-	08-08-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199204122012101001	UMUM	Andreas Nugroho Indrayana	L	-	12-04-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199210192012101003	UMUM	Faisal Muhamad Lufti	L	-	19-10-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199409062013101001	UMUM	Gunawan Septiyadi	L	-	06-09-1994	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199210242013101002	UMUM	Ade Firmansyah	L	-	24-10-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199312192013101002	UMUM	Ema Silaga Waluyo	L	-	19-12-1993	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199207172013101005	UMUM	Moh. Afifudin	L	-	17-07-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199111272013101001	UMUM	Wisnu Wahyu Wardhana	L	-	27-11-1991	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199303022013101001	UMUM	Dhanang Diandaru	L	-	02-03-1993	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199306202013101002	UMUM	Tito Cahyo Pambudi	L	-	20-06-1993	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199308182013101003	UMUM	Syukri Mahardhika	L	-	18-08-1993	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199203262013101001	UMUM	Ferry Dwi Fitrianto	L	-	26-03-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199203242013101002	UMUM	Surya Ramadhani	L	-	24-03-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199401062013101002	UMUM	T. Rizal Syahputra	L	-	06-01-1994	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199203082013101002	UMUM	Pralebda Yudhi Framistyanto	L	-	08-03-1992	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199410232015021004	UMUM	Angga Achmad Taufik 	L	-	23-10-1994	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199504202015022004	UMUM	Aprilia Kasandra Romamora	L	-	20-04-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199410102015021003	UMUM	Berlianata Patria Justice Bangsa	L	-	10-10-1994	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199601302015021002	UMUM	David Marudut Tua Simangunsong	L	-	30-01-1996	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199502112015022002	UMUM	Dewi Puspa Ariyanti	L	-	11-02-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199502152015021002	UMUM	Dipo Wisnuaji	L	-	15-02-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199509052015021001	UMUM	Muhammad Alfath Wijayanto	L	-	05-09-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199505262015022001	UMUM	Muthia Afro	L	-	26-05-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199511132015021002	UMUM	Raden Muhammad Raka Aditama P.	L	-	13-11-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199512092015021001	UMUM	Reinaldo	L	-	09-12-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199503202015022001	UMUM	Ria Al Whali Rismaya	L	-	20-03-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199412292015021003	UMUM	Risanto Ardiansyah 	L	-	29-12-1994	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199509142015121003	UMUM	Antony Riza Putra 	L	-	14-09-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199602262015122001	UMUM	Dhanyta Fitriani 	L	-	26-02-1996	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199504072015122002	UMUM	Gery Catur Wulandari 	L	-	07-04-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199604152015121001	UMUM	Iki Pujaningwang 	L	-	15-04-1996	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199611262015121001	UMUM	Krisma Novandi 	L	-	26-11-1996	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199610042015122001	UMUM	Maria Magdalena Claudia Centurini 	L	-	04-10-1996	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199607302015122003	UMUM	Sendy Via Anugerahsari 	L	-	30-07-1996	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199504142015122001	UMUM	Tisna Anindita Aprilia 	L	-	14-04-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199601162015121003	UMUM	Yanuardi Rian Rahmawan 	L	-	16-01-1996	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199512242015121001	UMUM	Rifky Vega Defandi	L	-	24-12-1995	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199712072016121001	UMUM	Reyhan Putra Hariyadi	L	-	07-12-1997	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
199702232016122001	UMUM	Nurjihaan	L	-	23-02-1997	-	Pelaksana Pemeriksa	-	PNS	Menikah	-	-	\N	2017	1	0	T
\.


--
-- Data for Name: tblakun; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblakun (idakun, akun, nomer, deskripsi, kategori, pajak, saldo, flag, ketpajak, h1, h2, h3, nourut, trial822) FROM stdin;
\.


--
-- Data for Name: tblanggota; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblanggota (idanggota, jenisanggota, anggota, jk, tempatlahir, tanggallahir, noktp, alamat, notelp, pekerjaan, status, namasaudara, hpsaudara, foto, tahunmasuk, statusanggota, fp, trial822) FROM stdin;
\.


--
-- Data for Name: tblbunga; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblbunga (idtransaksi, fakturtransaksi, norek, tgltransaksi, bunga, fb, useradd, trial825) FROM stdin;
\.


--
-- Data for Name: tblgroup; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblgroup (dgroup, keterangan, trial825) FROM stdin;
Administrator	Admin Group	\N
Oke	ok	\N
\.


--
-- Data for Name: tblidentitas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblidentitas (namakoperasi, alamatkoperasi, namainstansi, kota, pimpinan, bagkeuangan, bendahara, notelp, logo, idkoperasi, nama, umur, alamat, pekerjaan, noktp, toleransi) FROM stdin;
asdas	-asda	asdasd	UNAAHA	Drs. MUTIARA TONGA	TRI SETYA B. S.Pd.	Drs. MATIUS PAEMBONAN	08888	\\xffd8ffe000104a46494600010100000100010000ffe1007e45786966000049492a0008000000020031010200070000002600000069870400010000002e00000000000000476f6f676c650000030000900700040000003032323001a00300010000000100000005a00400010000005800000000000000020001000200040000005239380002000700040000003031303000000000ffdb0084000302020808080808080808080808080808080808080808080808080808080808080808080808080808080808080a0808080809090908080b0e0a080d08080908010304040605060a06060a100e0b0e100f0f10100f100e0f1010100f0d0f0f100f0f0e0d0f0f0f100f0d0d0f0d0f0d0f0f0d0e0f100d0d0e0f0d0d0d0e0d0d0d0dffc00011080140014003012200021101031101ffc4001e0000010403010101000000000000000000000205070801030604090affc4005a1000020200040303070806060605080b00010203040005111206132107083114162234415154326171749394b3d20915234252812443536272913392a1c1d1f06382a2b1b235447395d3d4e2f11718254555647583a3a4c2ffc4001d010100010501010100000000000000000000060204050708030109ffc400441100020004040306030504090207000000010200030411051221310641510713226171813291a11452b1c1d1154272e108232433628292c2f016f134536373a2b2d2ffda000c03010002110311003f00fa0bc27c2153c92ab792d6f56aff00f9bc7fd9aff770f5e65d4f85adf7787f2e13c13ea95bead5ff000570fb84218fcc9a9f0b5beef0fe5c1e64d4f85adf7787f2e1f70610862f3229fc2d6fbbc3f97079914fe16b7dde1fc987dc184218bcc9a7f0b5beef0fe4c1e64d3f85adf7787f261f70610862f3269fc2d6fbbc3f93079934fe16b7dde1fc987dc184218bcc8a7f0b5beef0fe4c1e6453f85adf7787f2e1f70610862f3229fc2d6fbbc3f97079914fe16b7dde1fcb87dc184218bcc8a7f0b5beef0fe5c1e6453f85adf7787f2e1f70610862f3229fc2d6fbbc3f97079914fe16b7dde1fcb87dc184218bcc8a7f0b5beef0fe5c1e6453f85adf7787f2e1f70610862f3229fc2d6fbbc3f97079914fe16b7dde1fcb87dc184218bcc8a7f0b5beef0fe5c1e6453f85adf7787f2e1f70610862f3229fc2d6fbbc3f97079914fe16b7dde1fcb87dc184218bcc8a7f0b5beef0fe5c1e6453f85adf7787f2e1f70610862f3229fc2d6fbbc3f97079914fe16b7dde1fc987dc184218bcc9a7f0b5beef0fe4c1e64d3f85adf7787f261f70610862f3269fc2d6fbbc3f93079934fe16b7dde1fc987dc184218bcc9a7f0b5beef0fe4c1e64d3f85adf7787f261f70610862f326a7c2d6fbbc3f970799353e16b7dde1fcb87dc1842193ccea9f0b5bec23fcb868e30e10a9e496bfa2d6f569ffa88ff00b36feee3b1230c7c65ea96bead63f064c2109e07f54abf56aff82b87fc30703faa55fab57fc15c3fe1083060c609c210138c6ec630610856ec00e13830842f060c18420c183061083060c18420c1830698420c1834c79ed4ba0d7ddf2b77828035eb8423d1831005eefe5c2119dbfaeeb4ac3d95e3b568ff00fd6864c333fe90ae1b27489f339cff00d164d99b6bf416acbd31e2d3e5a1b3103d4dbf186f16634c18acebfa42f86c1d1df3387ff4993666a07d24566230ed4fbf9f093b69faeeac4deeb11d9abe1f59861d3f9e093e5b9b2907d0dff08aad160b0635577de032fc9235ff003f7636e98f68a60c1834c18420c183061083060c18420c18306108c6ec1bb1838c610856ec00e13830842f06300e338420c31719faa5afab58fc1930fb862e33f54b5f56b1f83261084f03faa55fab57fc15c3fe18381fd52afd5abfe0ae1ff084184614d84e1083060c18420c2c0c0060c21060c1830841830634589c052c7c002c7dbd07cc3d2ff2c211b9861b338e2186bc6d35896282251e9cb348914683decee55547ce48c55cbfdee6fe73ba2e13a5cf877b46d9e6621a0cb54a3f2dcd3ae36d9bce08d7aac51ee5652fe8eb86cabdd792dc896b886ed8e20b6a7722dd2a997c0da1d7c9b2d8b6d450016019d253eff018d73c43c79856084ca9f333cd1fb89e261fc5a80bee6fd018ba954b326ea069d4c7679df7e5cbe5668323a57f88a553b59e84423a29a68747cc6c986b9f100885a53aebfc2da72357bc2712419b64e736a59650cb732bdfabdebd5965b56a39e6ad3c951e7b4d14516d33c4232b0a75d35d46803cc996e4d1c28b1c68891a0da91c6aa8a1478050a02a81ec000c477de2fb36b19a657341536a5c8a4af6a8b39f416d559d27859980d554b2e874074527a1f0c69ca7ed7e7d4623291a524ba62c03dc966ca74b96d069b9f0f5d63226802a1d6e62d4634d88f72e857a3746ff000b62a458adc6f986be519c65d9344fd4c594d2f2a99574d36794e6019416f12d1c0083e0da0d0f925eeb62c13fac73ce21ccfaea566cdecc109f9857a7e4f12f8feea83f39c6cfaded4300a52544d69847fe5a93f2272aff00f28b114535b95bd61b7b9965491e4fe4eb1287a398e6b45982a87020cc6d08d75001f42231a0d7d8a31613947de71c9f67bd98d3caabf92d083930731a428659656696520c9233cef248cee46accce493a9f124e3b1f9b1c6dc4188a57e23515526e11dd9806b5c0637d40247c8c4864a1440a770234f23e71fe4310177ccc9a39328103448cf7b30ca2929daa58f3b32aa1d75209f4e212274f6362c2018e47b46ecca9e6b5c55bd073e1e6248104b2c2cb2c7a98e4478648a54742755657041d0f8818f9c3f88a506234f553ae511d5982dae429be972072e661350ba151ce277ab069a05f923a2fd031e995714e22eeb8b06872dceb88b2cd0ebb61ce2cd883eef6fca626f0d3d30c74f68f1c7baa57e36a1eaf9be5f9cc4be1166d44d69d8007d1f2bcb8004f868f2576249eada1e9d9343da870fd490a671967ff005148faae65f9b447da8e72f2bfa437dbef0bc4d3e6d9c9ca6a6597f2ccb6f0cbd20b324b4ed4b3415a17b2d05a48a58b6f3a42804abd09d75eba2f5b9277e5cbe36106794aff000f4e480af7e11250909d7a266351a5aabae841e7987a80353aaebe3eee7d99cd96e550d7b855aec924f6af329d51addbb0f3ccc87a120336d1a81e03a01a0121e6593a4c8d1c888eae36bab2aba953e3b8302a41f710463585476c13e9f119c8b292653862148255b28360436a35dfe1e7bc5e8c3c1406e41893b24e22af66349abcb14f0c83d096191258dc7bc3a16561f41c388c537bbdd6d69b9b3c3d76c641649dccb4bd3cbe67f6794e5736ea8e0909ab4691b683a789d5cf2eef6f7b262b1716d21041bc4699e65a1e6cbdcbb8446b95ceeb5499d8ee3a09220cea03e84637270f71e6138e112e4ccc934fee3e8c4ff84ec7d8dfa8118f9b4d3256a469d62db60c68a76438d4781f988f1f98f5c6fc6c68b483060c18420c248c2b06108460c648c6308464615846178420c3171bfaa59fab58fc16c3ee18b8dfd52cfd5ac7e0b61084f03faa55fab57fc15c3fe18381fd52afd5abfe0ae1ff000841846178463e884185818c018ce3e420c183061083092d80b62a7f69dde22de6b62ce4bc324288098732e20651255a2fd7995b2f1f26de60bd0171ba2afa8258b03b71f5f5f2282435454b8445d4b1d87ea4ec00d49d0454aa58d9778b6617048b8adfddabb799596c6499dca899d6531979ec395863cc72e1af2b368fe4a052a36585524c332963a87d072dc4fde4f32cf646a9c29b21a2bbe2b3c4b6a1dd5d5d49564ca2bc800b9203aeb62406ba103a3eabad954633452293edd3272ac920307274208b8b7527901a9e422a12d8b650358638638f8778a66cab7a2d0e21e6e679743bc16a97d181cc2a88f5263af6770b30f4d85c4c01d770c58189b118f65fd80d2cb59ec0e6dccc2c8d6de6579cd8b93b1f1d267ff451b75db0c2a88a3f7491a993e118e16e37c5e8716c52655d0a1556b5c9b0ccc34cc072b8b687536b9b136893d2cb7972f2bc6dd308d7089a60b88738a3bd46555e76a90bcd99dd1b81a394c13661382341b641595e3889240d25923d3aff000b6d8a61f85d5e20fddd24a698dd1549f9db61e6748f777541762044cdbb017188528e61c6798faa64d472684ebb27cead73ac69d7d214b2f6729a7f0cb2a91d41520862f14fba9e796743997175e5ddaeb0e4f4e9508a30750aa924d15a9d80f7c8ccda9206dd401b5f0fec931ba919a7e4943fc4d73f240c3e64463deba52ed73129f307bc61be5e22ae3c66887d3220ff007e39187b83e44da795cd9ce6074d3fa6e7b9975fe55e7834fa155547b00f0c2aff0070de118a195bf52566291c8434f35cb4daaa1ea5a7b32313f393ae2612bb146b5e6d681e92eff8b88f1188662005dfcff947590712d73e13427e8910ff00dc70eea71f1a2af02544d0a43b4fbd249a33ff006245c3cd259a23ad7bb99553ec35f31b89a7f23336a3e63a83eec4666f66926f64ac3ef2bf4987f08df0dd96e30504c4694d717f8981faa5beb1f5f1a41efc1bf1f2f324edff0089ab1530e792ccaba2f26f56ad6a360074567312cc00f7a3a9e9e246a0c99c33dfe334874198e555eda69e9cf974cd1c9af4d0f93596604fb745990780d0630357d9bd7cb17a7992e6f906ca7e53328f913114afe0bc6a88169b4cc40e6b67fa25cfd22fb9c275c413d9cf7c4c83332215b7e4d70e83c96fa3539f71058246661c895fa6ddb0cce75eba0d63dd3a24bae35d62185d5e1efddd5ca646e8c08bf98ea3cc4430820956d08dc731ea39428e2bdd848b88f8a61ca8c88d97f0f08b32cc61deaa6de60fafeafadcbd75961adb5accc34da1b9409d760c5837188bbb52eefd473168ec69254bf01d6a66749cd6bd0381e8ed9a3d0489e04c332bc648f9035d44af81f17a1c27144abaf4665506c56c72b1d331077b0beda8dc5c8b45a54cb6992caac5a1880c20b62a570c7795cc72275abc56166a24a4507125488ac45d880a99bd68c1f2390f41e5118f2663e3cb1a91d2f796edde5415f24c92549339cd61df04e844b1e5d979d39b9a4ba6a8caa3415575d649190aee0bd7bb29f1aa29f49f6e95354c9b162f7d001bdfa11cc1b1ea2f11832d95b291ac5902719d3153fb36ef117729b15b27e266079e7939667e008eb5e61e8c75f3003d0a7981f633158ac10346d4e2d5c2fa8c5e5057d3d7c85a8a570e8da861b1fd08e60ea0e8758f8ca54d9846dc18306321144184918560c2108c2f180319c54610618b8dfd52cfd5ac7e0b61f70c5c6fea967ead63f05b14c213c0fea957ead5ff000570ff00860e07f54abf56aff82b87fc21060c183084183060c2106304e1329e98a9bde23b51b39b5b3c3392d97ae1406cff00328fe5d1af20d465f5a4d76ae63706aa480791036ba063a2e3ebebe450487a9a960a882e49e9f99e400d49b01ac54aa58e51bc793b4ded3adf115b9f26c9a66832baee61ce73980e8f2cbfd6e59964bd544814edb1693772376d5fef48fc0bc07572ead154a70c70578536246a345dbe2493d4b331f499d8962c75d4938c767fc0d5f2ea9053a91a43040a16358c69a28d493af8b16624976d752dbb563a93d6018e13e33e33a9e20a93a9590a7c09fee6eac7e9b0e64c9e9a9965af9f588c3b54ec0b2cce5ab49984065355d9a32acd199236003d794a15696b4a40692163b5f6aebd3507bcc9729482348a2448e38d76471c6aa8aa8068a11140555d3a0d000061d0639be33e37ab97c2f6ae4f155af12ee9259582003d8353e2cc7d108a0b3b11b4312062142aaaead25d26666553644b920127f757a93d06b173955496f9987e99b10cf1a778b4f29396e4d526cef351f2eb5360b053d41db266371ffa3d48891a6d66e612080bd54969e1ce1ace78aff68c6d643c3db875d1abe719cc7a78c7b807a1464dda893416255604683422cff667d9565f93d74a7975486ad75fdd897d266f6c92bb1324b2b78b492bbb6be3afb7a2384fb26ce16a7192473128687fcedcbf8575ea46a2311515dfba9f3fd2200ca7ba6e619afed78a33492489bafea5ca249a9d04041d52cda464bb70f5642565850e9a8d3a6962380bb2fcbf2b8961cba956a512f82d785210478fa45006727daee59bde4e3afdb8f1dabcb1a96621231d4b310100f79274007ce4e3a5e830fa6a19424d2cb59683928007d373d49d7ac61998b1bb1bc7bb1f343b7bfd2c56f25ceb32ca9326ad61295a92b89cdc950ca174d1ca08982920f500f8fb717178cbbe270c50668ec675444c8746af04ab6ec06e8047e4f539f373092008f66f624000e3e18f7b9e268aef12e736e012886c5f9648b9d0c904a5182952f0ccab34648ea16450da11d0632514c5ce1fa6daf7ff008055fbf4dffbbe345cfd347724564fd43506f565d7cba6e9b811affa0f9f1f35ce256eec1d9d7eb6cff2aa240659ada3c8a46edd0c21a79f5f98c5138d4eba6be07c0dbd4cf49125e74c365552c7d00b9fa08a901cc2d0e4bde20f87928fb4ff00e0c2bffac57ff945fb4ffe1c35779eece8e539fe694340ab15a678805dba43602d9834fa219a3008d3503c07808ab4c6229f0ea1a996b3d101570181b9d430b8fa18d963b46e2296320aa3a69f0a7ff989ff00863b6d366c4500ae139ae1376fdda6bd35d368d7fcf1269c55fecc8b797d6da923b730109146f2c8da753b638c33b90013a2a93a038b1f5f8a2b3b3289e30ca4ab239e5c8ac09054a49b5c302082a46a0e2318ce1c24b29a74216dadae79c7437667c64f88d34d5c56a54cdce328628a72e51b016beb7e51e8cc72c8a65d92c69229f63a827f93788fa41071d77675dade73931032fbad355046b975e679e023d01b6094b73ab1da9b46c7d8baebb4e39b48c91a8ea3de308388acd55992cc99e81d0feeb8b8f91d8f98d47231b4b16e1ac2f1a4fed12949e4eb60c3d186bec6e3ca2f57623df332fcd192a590d96e63a00b5acbfa33305f4bc96c0fd94cbe3a26b1cbe3e811ae2c7a9e98f8ff0098e4e93a1495048a7d8dec3ec20f42ac3d8411f4e264ec4fbd95fc94a4198b4d996541828b1b8c97e847d07a5e1e5702fca2181957d2d1882b19d458ef67f2e7033b0a366dcca63bff00031ffeadaf4626c2399f89fb3dabc2034fa6266c9dc903c4a3cd46e3fc43dc08fa179be5093a3c7322491c8a5248e450eae8c34d1d181565d068548209c703d9576019664ed65e8d7109b522b39663218d146915781a42cd156889731c00954dc74e9b42f5dc1dc6b56f568ec53b11daaf28d639636051c0f11ef5653f2918074d7d20a7503a238d346a6ae912651e665563674b900953a665ea0f58d49955883f231ca71bf00d5cc6ac94edc11cd5e6055e361aaedf78d082a54e8c1810eac075046b88e7b31ed3ad70e5baf9367561ec6553b88326ce663acb0ca75e5e5799cbe1cc206dab6db68902946f487a137e397e3de06ab98d59a9db8926af3c6524471fba7c343e2aea7460eba15217a8201c4d38338caa787aa79b4863e34ff72f461f23b1e445b54d389a3cf9189cd4e158a99ddf3b4ab594db5e18ceac34e183b70fe6336a1af568c0272fb1213b5b30a684687d133c210f56d435b3d31ddd415f22be9d2aa9d832300548e60fe041d083a820831192a54d8ef060c1831908a20c1830610830c5c6fea967ead63f05b0fb862e37f54b3f56b1f82d84213c0fea957ead5ff0570ff860e07f54abf56aff0082b87fc21060c183084183060c210018ad9dbe776a57966cf324b11e559d2c4649e494edcbb328e11af2f3688ed52a114edb6a564875dc59c01a59173d31527bc9f133e7b990e15ace56942b15be24b30b946581f492ae54a54ea24bba2c93e8daad53e1fb4da7098d545253d14e995d6324292e180208e963b926c00e648023d25862c02ef0f5d8076a6d9de5905e6ad2553316051983c6e63628d2d7906865ad2b2b1864214baf5dba685a50c36e57944702245122c71a22c71c6802a2aa00a8814755555000d35000c36f1c71b56cbea4d72d48b157af1b3c921f0d147b00d0b36ba2aa6859dcaae809031f9d35592aeadbec92caabb1c882ec4027c2b7dc9d844b54955f11f531e0ed33b4da7955396ddb976226802a8dd2cb2b748e18231e9492c8da2a22ea493ec0091c8765fd815bce6cd7cef8961d8207e6e5790310f0523d0a5acc57e4d9cc4f42236fd9d6d08da5b7055f77fecc6ce736e1e25ceebbc2135390657283a5181874cc6d21e8731b0be92023fa345b34f4882961bb46ed02ae5142de636df9756a4124d21f13b57aaaa0fde9243a2220ea5d95475c763f00f014bc1258acac01aa587a89608f847f8bef37b0d2e5a3f5554669cabb7e3116778bef9794f0d4f5ea5a16ecdeb313cb5e8d1804d3ba2b6c527565082570e91e9f2cc6fa6dda715ee87e9349b30631d08325ca88664e6712e6eb55d1ba052f4e1883a81d4e8d61430fdf5f1c767c23dd82c67993e63996687c9b8833e92be655a652cc7233506fc96b404ed70b57a3cca0a894cd2743a0c4b7d8071e43c459703995383f595199f2fcd6a5886391a0bf5c8594aabab9e4ce36cd1b11a3238f120e374da31d11b64706759c2869b8f3298e27d748f8661a040d48e82d5bb1725234f0d8a181fde6dda63ac83b88646efbf329335cee4d492d9be6566c2b12412dc889ebd503a782c0174d7a63a9e23ee75c2b6cb358c872d766eace95a385cffd78446dfe4d8e4a7ee0f900dde46736cb370ffeefce73081174f6ac6d61d3fcd48f9b1f61131f03f64194e5aa132fcba8d45d48515eac517427711bd1158ea7a9d49d4e3e1cfe909c9b671ae74b29e5acb62bc81b42748e6af59b99a0eada02c741e3a74c7d641dd67338f5f22e33e238869a05b872fcc82fb80e75342c07d3b87f11f1c7cc4fd26bd9566596e775e5cc7304cce4b9450a5b4a4b44b2d56687649124b2a34b1a840d2a95dc0a1d89d308479f813f4775ccd2b47732ecdb2cb75e51aab2b4aa54e9a9596331ef85c783248aa54f8818b4bdc87b8ddee1fccace617deb48de4c61abc8767dad24839cceae8bd046a157693a876f77a5f38fb1aedcb32c8ad0b5974e6363a09226d5e09d14ebb678750b228d3a7ef2ea4823c71f733b1ee319f30cae95db300ab2daad15892b82c4466441200372a3755656da46a15b692da6e3cd5da66238f61721a534e46a69d741e10b30732a6c75d05b301b6e01b4662892539bd8dc7ca2a7f7deee357788332af9865ef5a33e4c20b3cf91977346ccd0b2688da8e5bed6ea0eaa34dda8d2adf1d7e8ebb995d592e6659b65952bc60ea59a66666d010914623df2c8da8da8819dbd80e3eaaf6b9c673e5d975dbb5ab8b52d4ab2d84aec582c86205c82caa5ba2866da06a76e80ae9b97e19f6c7db9e659f5a36b31b0656ea238975482052752b0c3a9551ef6d598f4d5988d715766788e3b89d3aca135169a4d93e10661e61474d34cc47a03ac7dad494876398fca255fd1e9927338df2458f5758ec5897769b758e1a961f7ed3d5750a0e87a8d71f72f8d7b22caf324297f2ea37174d34b156297a29dca033aee1d7af461d71f023babf15e6143307bb96cf1d6b30d696213495e3b1b1670118a4727a01f41a063ae837743ae2c9e6bdbf71358d79fc4b99b6a3422b0af481e9a1f568534ff002d7e7c6ffaac4a9e99b2cc6d7a5a25381f026338cc8153472ffab2480c5940b8363a5efa7a45e4e2bfd1afc2d64b3d7ad6f2d94fefe597648829d7c5639c588175f02390574f62e2bef691dc5ab511cc878ce8c08be8b479e0a6ba1d7f7adc7620dbd341a187527dbfbb8ab99c527b236dbb998dd5f1db6efda9c7cfd1a5d3fc80c7869f05528fe455847ce54b9ff372c7fdb88fd46354533e2965bd408dbb847667c4f48414ae12bc95dff00003f38f471ee66d967cbb792e64036d2d936642c9f1d01e5b461c8f6eaa5947b49c78f8578de0b65d62deb2463574906874d743a687ae87a11d0f5c6ecff335ab17ec63512c876448a800790e801e80755f95afd1867b7c206b4514b0e8d66026473fdb97eb32b7816d7d83d9a103a9c619c52ce5ccb2f216365d79f52390bd87bf946c8a47c7b0d9e654eaa15292d434e1dd804293601581b96cb76b11b0ff0010894bb26ed56e70eda6b54b59ea4cc0ddcb09d23940febeafb21b28352081b24036b6be8edfa43d97f69d5736a91dea92896bcc3c475923907ca8255d3549623e8bc67a8e846a0ab37cb5cb73249635953e4b8d47cdf37cc4787bc1d71d3765bdaddae1fbc6f56569aace54665481e9320ffcea1f625b886a75d3f689b9588ddb9757f13f0ba63285d405a95d01db3dbf75bcf92b1f43a5888971bf04ca9b2bf6be12b75233b22ed622f9d00f995f71ceff0054f4c46bdbef6a8d93e5962f2d67b46208a155b6246646d825b120d4c55a2660d34aa8c513aedd3d21d6f02f19d7cc2b57b951f7d6b112c9149ec752351a8fdd653aab2368c8caca402a4071ce3294962922951648e5468e48dc6e0c8ea55d0ebd76b292083e20e39ae9b2525628ac96595186743752403e25bee0ee239d9aeca6c75e51c57611dd9424b16799d588b36ce9a32f04d19d72ecba3954158f2c8b5202942035c2cd2ca3560ca1949b24d8a8fddb389e4c8b313c2b69cf91cab25ae1bb12b1666854f32e6524b753252d5e4afab166aa76e8796145b976c7e8b60b51495145266d08024b2828145801d2dc88d88e46f7d62253030621b784e0c18319b8f383060c18420c3171bfaa59fab58fc16c3ee18f8d7d52d7d5ec7e0b61084703faa55fab57fc15c3fe18381fd52afd5abfe0ae1ff084183060c210631809c41fc73da6dc9adcb432c68a05aa556ee612a09cc5332c728a752bee54927e5309249a6668e0df1af26766710e1f16c5a9b0ba76a9aa70a8373f9003524f20358ad10bb055de256e2be28869d79ed586db05789e695fa13b235dda05001676f055d4ee620004903142bccace3253366d97b89e6cdefb58b5c3f64b9692d5e994430d3bdacb3c76618362ccd60cb5c886697f6118091c8f4694f7f31f266cd6ee634683c73df8e792949049795d27a506c86a44ead5484baea1c6c7348153ab6de9fb26e2daf7b3d69240e23a89621c9cb28305ab3113166b3c12ab30362b80d4d626556545b8ebbd598c7a66bb884713d7d3e174c3fb3919e7778a3c40eaa9aea1994665b10c010c0f84c6456499285db7e56fc635f665de0e9e64f25529353ccab9db672bba9c9b9095d353ca6e9342412cb342cc8c3aebd74c72dc2dc3be76e745df779bd90da1e8f431e6f9c4043153ec929d06650c847ed2c03ae8148c4ffdb5f777cb33f8912fc1a4f0822bdfaee61bf518f50d5acc7a3a10da31472d138075561d71d0f65dd9ad6c9e855cba8c612b5388471af8b1d4967924200df24921695d8f5667663d75c67b02ecda8307c49abe5b16007811b5c8c7739b9d868b71a5f5b9b18f19b58f31321f7f38ec89f47f962ab71c4be747122650be9649c3b2c37337601b977737d79b472edda04922a8a3caec20d06f291b69e27bbef6bdb93e4192dab9044d3db91a3a5411636901bd6494819a34d59d237d6568d577b85e5afa4e3109f77bef11c3f90e5705054cea79f57b17ac9c8b36df6ef4edccb565cb57dc0c9293a027511ac6ba9031b65a7cb97f1b01ea40fc62c80bc5da8e2c555edba0f36b3c878a225232dbe21cb789635002c680edcbb366e9aff44919a199b5ff004526bafa2747e3dfdf23fec33aff00d459affeed864e29ef8fc3976b4f52d55ce66ad6629209e27c8733292472a9560c3c9bf8491ef1e234d01c79fdb247df1f310b18b3b56c02010c08235047815f78feee37e2a2770aed9fca61b99148f6a67c9191695bb95ac579ede532ee5a524d14f1c4c93c011a07d54abec05491d45bbc5d860c2e0dc47c8c838a21fa5d7b1b7bfc3d0e650a079728b3cc90e9ab8a365447368402484985791ba81b4331f92317bb0d7c4390456a09ab4f1acb0588a4866471aac892a9465607c7552753ee38423f38dd86f022e639bd0a5232a452ce0ceeec11120855a6b0ccc7a28582391b7368069d48009c5d0ef4bfa460047cb3870ec441c997321fc2a36f2e929f05006d13beba80768d183e2b9f7c0eeb3738533396b36f7a164b350b5d42cf5f7abf2a5d35fdb41e82c887e51559175561a57c3ae22f89f0e526295726aab0671281c887e1cc4eac4733a0001d05ae6f716f649cc8a42e978fa2bdd3ff0048d0291e57c48dba373c94cccfc90927a252f201e90d0e9e529d42fcb0746734b3b79e045cb337bf4e36578a29d9abb210c8f5a7513d67561e8b2b412c6432ea0fb091a131f283e1f3e3b2e01e0c96f4caa4b725340efd4844d4b6d5d7de49d147b4938f2a2c068b07a99d5b4c3bb5983c683e1ccba860391d4820686fb08c8d152d4e273e5d24952eec6ca06faf5f21b93c844afd89f0ff00269991868f3beeff00f6d7555ffb5bbf969efc77bae08ab8450aa345501401e0001a01fc86104e211593cd44e69a799fa728fd16e1fc29307c3a4d0a6b916c4f56dc9f724c2f5c6c5ff2fa7c07d38d4a31cf71ad999ca53af14f2cb601693c9a2967912ba9d2422388331e84027c3af5d3c4f9d3c9ef9c20f73d073fa47b6358b4ac2a8a655ce22ca34be97626ca2fcae4817e518e1f1e532b5b3fe8a3d63a80ebd7d924fd7dacda05f70047ee0c74eaf8f2d28a445544cbf3554401540cb2dfc91d069fb3f1231bb74df019affeacb7ff00b2c7bd40677f08f08d00f21faee7ce21f83f11e0b4b4f69b5b29a6392f30e61ab36fec34551c94011ce515156d187e4c16497847b125fde8fe86fdde9e3a003c71d28e9868e26caa59e268cd0cd776a1a36fd5d73d1751b95ba45fc434fa189c2f85b3a7b108692368a58d9a1991d7632cd1749032b00cadafca5206d3a8d350715d44b6796271df66fc8fb8dfcc79c7a70fe3740d59330ca59c931083325e520e517f1a1fe126ebfe136fdd89bfba4f6d2725cc572fb0c4e55994a560d5b45a1984ba6dd35202d7b4c369551e8ca51b4f96c6dbf6e1de872dc8d765b769ae3aeb151ada496e4d4368cc9a8e4c676f5965daba6ba162554fce4ccf2d49a368dc6aae083ef07d841f6329d181f78c76bddf7b3bcbece6f56b5fb4f5e2b527edad4ae1e7b73ee8c4358cd36f01ed485577389000a50287991961b59c1f87e335f2eaa79218d83aae81c8d98b72d346b0b9b0b58926353717f67ff679f3b1092d96942976005d95afaaaaf43b837d35e4008ed784bb6a9f3ae20cb64e208e5cbe954b51daa74a17920114a124e5da92d6c13db41b967d613040f552e312fe4fb65b7f9c67d2d7cdef66c1d8c70e69572fb112b1e59cbc414ebb332b3842f5adcd2de12ede608b9b08de1fd2a81df3ee11c4f9ae8db4c0d48572daed88c742a32a85e9fb2e633ee41a2ba338f073ac87d9576a69732aced2593f6af9679521924076f2a90cb957524b96ac6ad58259587edad2cf28d049b12538b4e9985d1a4ac31722ca9d2fc2a34285c061ef7d4dc9dc93ce391f0fc416b2a27238b10cc05fa6b6e9b6d1f46d64c297105761fdae5cb761a3bcb12a5baed7b2be586465aeae913569b71224982495ad991761d6d4b104db584b34ec0e36bd0d6c9ac94274860ca49171d4687e441117854a9b18ce0c1831908a60c31719faa5afab58fc1930fb862e33f54b5f56b1f83261084f03faa55fab57fc15c3fe18381fd52afd5abfe0ae1ff084183060c211cf71d712ad2a962e30252ad79e775fe21144d2051af4d5cae83e723159f27e1594c396654cec27cce59ad669342cc9218c992fe64c8dd597ca6cc8b497690d0c568b29431a62c8f68bc2c2f51b94c9d0d9ad3c1bf4d7634b13223e9eddaccada7cd8a93c4fc493595cb7933791e6be56f925e83d31621e74265cca38a4531c9148b5e9b59ad6b6ed921db2a29132b2e9be3b1fdaf0f993d49a5498ef32c2e2e8b99330e9f16fa5b78bfa6f85edf15b4fce245afd85e6555ac65f97251ad975b9e4962b6b298ac518a67679e28e80aad14d2c0348eac89612329b0c81393a4fc4e44862ca32368c6b255cdf28af599541678866f065b2c8a174d059cb64b2f2b7b239a463d030c6dbd259a7984b9764c9222dbcb1fca4b5826b5079acc71c37f9534926eb6b5e3beb188223e5132c226754559476bc0190476333a74ebae94b208d249743aa0b6d01828d76f105e185a5b8eada346c6a37f59d2102661f8ae2140d84ca293264efb4cdb9b90a97f8b5360fae51b58dc0f145c10e8ae261d00b0f7fd22ccb3613ae30c718c74dc622218ef55d954f9be4b6abd5216f40f5f30cbcb69b7cb28c896205248d556629c963a8dbbc9d4638eec57b59ab9d518ecc3e83ea61b55a40166a9657a4d5e68ce8d1bc6fa8d186acbb481a30c5972310076afdd32adcb8d99e5d6ed6499ac85567b74551a3b6114aaadea6ff00b1b3b7a6d7263900000703a8d61c73c1abc474e991c24e977c848d0ded756b6b6360410090796a62f29aa4c93b6863a7de3dc30c1c69c595695696d5a96386bc285e591d828541f3fb75fdd1d58b11d0920e3891d8e71aae88339c8641a10657caae24a7d8bfb35b822d4f89036807d84783a709773ae6d986ef10e6736793d7712c158c295729ab28f932ad046713b2fa255ad3cba6dd42ea341a370eec831169e0564d44960ea54b331f200a81af5274dec768ca3e20807841bc1dcdf83ecc9facb882e43256b19ecb13d6af2ae92d7caaaa32508e4ea42bca247b0ea1574322a9f90a059ac241c6646c75b51d34ba69292250b2280aa3a05161f48c0b12c6e6305f11576ddde4f29e1f8565ccec04924d7935221ccbb608f11040be9b00740d236c8d351ab26a310ef7afefb51e4c5b2ccac476f3929ab6bd6ae5cae06d9ae303a9946aa52a281bb5dced1e8164f9dd6659259e4b96ec4d76ece774f6ac36f9643aebb575e90c29e09045b2345014280001655f8a4aa4163ab721faf488ee298c49a1163e27e407e7d2276ef0fdf36df11549b2d5ca2956cba6f6e641aeddd47c99a2485e28aacd1b13b184b330eba91bc8148b3dec0e55eb04cb2f41aab8e5b6bf311b94ff00323f9f8e26779bdd84f3310c6c7aa8b661603a5b4fd7eb1afdb89ab4be70401f76da7ebf5886725ec1246eb3ccb17b9631cc6d7e7236a8fe44ebf378e3bdca6adba3188d2186c42bf28c039537f88ee2e8e7da7d3d75e9d7c31d4f37a6329262de6e2b3a7e93802bd2d61f4d7eb19cc178ff0019c1eac55d1cc0adb5b2822dd3517b1e71e6c8f89e0b20f28e8cbf2e371b6443d3a329ea3e63d41d7c71ed65c33e7bc3a9390fb8c53a7fa39e3e9229f71fe343ee3a8fa3a1c68e1fe2a3bfc9ed009600f4197fd1d851fbf19f637f121eabf474c5a3d3abae7917d3753b8f4ea3f0e7d63be3b36ed9e9389ad4588012aab97dd7f42763e51d02e1c38778da4ca6f52cde2567f23918598a3203cd4ac2f2a745ddd19d469222b1d81d149e9ae3c270b8e520e31ea575571756055875522c47b831bff1cc22562d43328a6e81c6fd083707d88063eaff0007f15d6bf5a1b552549ebcc8248e64ea8e0fbbda083a6e5e8cac0f4041187dddf463e48f04f146619548f26517e4a3cc70f2d56459a84cfed2f5dfd14246a0b440369a0040e824b9bbe4f15b02a25c990e9a731294c5f5f78592cb26a3c7aa69f37b31a56bbb399e671347529dd9db3e65603cec0836ea0ebd06d1c8959d9f6394d34ca5a7ef072642b63fea208f3b8f9c5dbedcbb61a791d096f597f903657886865b56181e5c112fa3bb7b0f4b420220773a69a8f97b93249cb692760d3d99a6b7636f873ac39964d3c7a0240f13d0789c7bf3bbd66ed816f32b73e61694111bcda2c7003a6a2bd78f48a1d741a841a1d06a4e98d6ed8d9180e072f06a5690af9e63905db61a5ecaa0eb6173726d73c85a374f007054ec1ddababac26b2e55506f941209b91a5c9036bd873d6138f552bd244f1cd0bb4734324734522e84c72c4e248dc06054ed75076b02a7c08209c78f5c295b12104a9046e2374cd9693d1a54c175604107620e847bc4c995703dfe3bcde36ba22d1205af6af434985782289249002bbdd24bb2960abbe556552ac142288df99ec0b24820ce23a361a62a924f0c6e5da0793f68218a1997424897328b2894d756405e4b6352924b04f35772bedfe2cb9331cbefe61052acf09b145ac0548c5a62567fe91a0eba725d6272492642bbb6155a89478c9e1b95a5977ab8b0d31b6eea59b7064b76146fe606304b3ce8ce17d3037a2fa49899ab07952daf989be6bfa6d6e91f9e5da35156d362dddd3d27774d24917453942b6cccda5c93626e4f947d32e00b7fb6e1374d1798ad0b74ebca6c8adcfcb1edd39b5a2247f7062d245f2714238678f65683265afa0bd0decc9210177470b490cf463322b10c529c39a2cacacc866f24603617502db762bc55358a7b2cb07b54ec4d4ec48005e6b42c0c33145d151acd692bd8645002bcae146d0bae03809a5d1c97c36637f599e6b81cca7785437a13b4442abc444c1b580f7b5e244c1830636dc58c1862e33f54b5f56b1f83261f70c5c67ea96bead63f064c2109e07f54abf56aff0082b87fc30703faa55fab57fc15c3fe108309270ac31718e7cb56ad9b446a2b579ac303e05618da4207ce42918a58d96f08e238cbb6f4af60d3ab5a5bf7136f3923748a0aaac9cc46b76653b222ea54ac31258b04491b7295099161ca37a7cc73e162de5f46a58cb6830e75499ee49235f9748524b3350a328e4415a6fd86d9100b20861d75dbc2d975a8ab65946175fd619ac865b571873364ad0bddcc6eb47236b26aea6182262e8924d5508e4c2caacb2cff00a94e750b0bd6b349ec3c95239237926bff00d1a1828b472c5147559144491cac9ca4adb6569444a0b37346358de338ed0d4b524b1f6677ee65e504bb78c02edc9572e6076b123ccc6665cb9529c063e21af96db7ac3cf647c1e99cd8cdaec79cd8895b317a72d3a8b592448a82f93431bcd244f66216268ec5a8e48ca6e49b5571d08b1fc19c135a8574ab52258614258282ccceeec5e496591d9a49a79a4dcf2cf33bcb2392ecdbbc2b3765d0a537e18b7559b6cd156cb6d162c25b55ad559268da6556d9ce8af08a70583ec125b44d39ec4dc17c6d0e086a19d4226524a0854f74e6c33132fc2331b6b7500fbc58d4e60f663e7f38d783060c6c98b483195c630c3c63c5b5e8d5b172ccab156ab0c962691be4a4712976274d09f0002e84b1d00049c210e599e6b1c286596448a28d4969247548d0786e776215541e849200c551e3bfd25dc3f558c74d6f671203b49a10af92fa2013adab0f0c4eba1d374425f4be63ae29276e3dbbdde28b066b665af96062696541d8461376e49ef2a1d962d49a0701cba40340ba967693873a0d00e800d06800007b801d00f98622b5d8ea49632e50cc4733b7f3884e23c4b2e43995217311b93b7b5b78b779d7e93cccddcf9370f5789771dad6b33767d34e9be2af54aa9feeac8ff4e382e2deff005c53651e285729cb9248d939d0473d99e20c08df0b4f2246255d7552d190081a83ecafc5b182f8c03e3b54db651edfa988c3f1356b6d947a0fd6f09a39708f71dcd248ecd24b24877cb2cce4b492cb2b12f2bc8c4b33b927538c9738c1384e304eed318b39b93ce234eed358bb9b93b9306ec6776138314c510add8ceb8460c7cb47cb46d27a63cf9ce491594e5c83c0ee4707478dff0075d5bc5769f123c7c0ea31b0e14ad8ad1da590ca6c447b4a9af25c4c9648606e08d0830cf56be6884012539c0e9accb2c4c47b0c8501f488ea49d493efc6c39be60bf2a9d7947fd05820ff00212a0ff6e987812e142638b86a9cdf14b43ec47e0446e5a1ed9b8b68c055ab2c072601b6f510cc38fa153b6c453d46d74d654dd1fd1cd8b7293f4edc7448e1806520ab0d4303a823e623a1fe58d528561b5975523420f507e6d3dd8e4eee56d4759aaebca1d6c55ebb0af899215f04917c7450069af4d35d7e8972a7e89e16e42f753efb8f7bc740f047f4879b3e7a52e3d2942b103bd4d2d7d2ecbb5afbdadef1d81c6b2719a76d6544910864750ca47b548e9ff3efd70118c7152a483b88ee149ab395664b20a917046a083b58c241c2d71af4c2d71418f710e592d18e49a18a6b095219268a396d48a592bc6eea1e665046ab183b8ea55469ab3228665b25debb80286439450c8ebc71596b734f9858cc25484dd7dae36b068c26d0eb28aea57406b47cbd09776c561dc46854ed652ac8da03b5d08643a1d41d1803a3020fb41c4abc7bc459d71bdeab0578a117a9d2952435b62c4f1eaac67b26c16484730858e3424ef9986ada1d923c35d4ca7969fde1b006c4e9cf606d1cc1db5e058ae234e8d49302c80a736660aa083bf5248db7da24eee852416568cbca0b38b160b91b4686ad286a97d83e4b4f6e6cda52cc5de5122bb1f911c56ebbbe6bcfe21d75d3f5dae9afff00a16443a7f3d7f9838a11dcdb3d952d5749c72996e4f1ca1b4508a68492b47d095676bd666676ebb63893ae98b53dda7b619a7960610a0cbf37bf990ab3fa62669a3334904fd48434e4a74b9080af31a68d1d7746f1b08ed18fb3f1499f34e54321652f9bb4c242fad918fd6395e9dccda343cf736f4d62d99c18c0c671bbc47841862e33f54b5f56b1f83261f70c5c67ea96bead63f064c7d842781fd52afd5abfe0ae1ff0c1c0fea957ead5ff000570ff008420c471de0b29927c9335861079b2e5f6446aa09663cb625540f12c06d03da48c48f8498f1e73573295308ac6fc655a0bb9466af228cbdab5a8f9da83143e5c904d56576d42471c8613007242892c4235f4c63cf7fbca66094a2bf35280d3cca202a57ade50d7e196e42cf97accc77c33b3cad04536c4812bbca5f98f1c0599ff008afb1ab7516d7eadf27b1466334a72fb8f2426b1937bca94acac53835da4dce94ec47b20dc5639638e38a011750e779bdc3461589e62b901459a56862dcd0c0bac92ac73b469d49256291bd814eb8e6befb18e1749185cb5190cf2a8da1ef55f31b1bfc241dcf98b1b037cc592a0973d3e5fac761c25c36d1dae16cb832b3532d3da047568a8e573d612f4f06f2fb351c6bd08ddee0a6d73ae218eca78562a6f35ab97abd9cc2c8449244922482b578cb18aa558cb33ac48c4c924b2b3c962672ec502c30c127371456f88aff6f1e36ef07e113308c3964541066b1676b6d99cdcfadb6f68b69e8f31c9086db0d0ed0e84631a61a8f1456f88aff6f1ff00c718f3a2b7c457fb78ff00e389c675eb16bdc4dfba7e461d1db141bf497f6b492265fc3f04c8cf6a5f2ccca3420ba55abd6082700ee4166c30214aeac207e80681a70ef7fde27f53e4b349465864cc2d4b1d0a0a2446d962c03acda0d41f278d659b6b7a2cd1856237127e5ed0cb3945d99da69e53bec5894979a6909d5dde5725d989eba93d3c0000ea7078b62094d2f28f8981b7979c4571fc4c50cbeeedfd63036f2e573f942ec3e3c9ae3631c208c6b311a7161383060c5715c183060c21060c183084183060c21060c18308418ce3183084294e36a9c6a5c294e2931f0c3270a4a2bcf629160006e7d653a758a5d4ba2fbf96c00d07c95dc74d3769d4b8c33f10e431d84f4c10ea774722f492271e050f89d0feeeba1ea0e9a838c70b67cd2c244c55678246826d4e819d34f4c7f8d4ab7f3c5f4f5efd7be5df4cc3cf6b8f5e7d0fac7e90761dda44bc5a8d704acd27495f0b13a328fcc7e10edb7190309f294fe35ff5b18f2a4fe35ff5b18deedba1f94757fda24fdf5f988da062ec655c7ab96f67a96615821b16627cbd26ada2b09259e48a59eccbb5596ced8e49258c173e53e82b1d4486910b71ff00689feb626eec4bba66639fa4339db0e4f2d9984d3bcdbcb9ae5e192582a10d119b9d19ae26982321566db2222f373d84998aceaa84e616bf4f38d19dad50d2e2386209958b27293a9f15eebb00398f3d3cc470bd89a42d2dd88fa63c8e5b10ede936b06579d4b623af26bfb036e3af0529a641ce15e4658da2775992ff00f0f70d2579f872844a04704a64dabb576454f2db2a1b68d3d1e7490a36d1d0cabefc505e07e15ab4338cceb53b0d66ac72bd7ab61d551a459ddeab0d8a8919d649e4406345571a1000718bb5c37db2d719ecac2296cc7524a99319e300c54ec6656201233316d25796c4b46af26153242b158964e5c6d01962f89d219b8de1ea4d9119dd8dec09011537d2e5dac073b9b6f1c5385aa4aa36496f9c02555ad6b8048bdbcc0b9e916db0612870ac6f8841862e33f54b5f56b1f83261f70c5c67ea96bead63f064c2109e07f54abf56aff82b87fc30703faa55fab57fc15c3fe1083180d8ce018a4c22bff68bc7d72f4972ad19fc8aa52dd159bb12452589e755264ad57ca239628a18c1e54f64c52c864dc91985a3790409c4352acfc199125e2a6abc1c32b619a66854239a2a58ce8e1a20bbb7170cbb74d49d35c75c9b4e5022242acb9ebd3cc18742cd63894d6bea74f6d895e68642343a4ae415201134643dd9aa412c23caae4946b4864ab9549e49fabeb11aec442b512ec90c04b186bd8b53429a81b1c47084e775a2c4b8a6ae65419a1129eac2aaea19565021ad61f135c1d4e847a465fbc5a7002ee56f78f9efde0fbb5264fcab55ff006f96cd208b5940692acae35895a45004b5e53aa472328757d8aed27315c44032d8ff00b34ff517fe18bd7db0f0f2a70cf10d11a98f2d9ef2d70da7ece1ab38bf4a25f0016ac46bc49af5e5c49a966dec68eb629c22aaa5d26c8aa6cd324cd79458699c2d886f520fd073bc763f65b8ab62545325d4004a65b1201366be84f3b106d1e5fd5f1ff669fea2ff00c30af208ff00b38ffd45ff00863693801c67333758ddbf6793f707c84731c535116c65a5502833cc18a803d2e4fa1ecff17f99c7492b619f8e2a3340248c0325674b29ef6e51d5907bf747bba7b7403db874a7796644950ee4750ca7e63d7ff98f61d463253aef225bf4bafd6ff9fd23f33ffa4361136978856af2ff00573116dd2e3423f38d4d8c63718f1931e2c6f1cb5711a718d98de62c2649514842c379f05d7aff009789fe58a85cec22a5b9f86346dc1a63d261c27958f99a198479f063695c27155e3ede11830adb8508f1f2f1f6f1af06377231b560c7ccd14e611e5d30698df1cd19254302e3c5751a8fa4788fe7836e2a371b88a8dc6e23485c294636f2b004c5178f3cd0b81fc3175ff45f6531bc3c45cc4478d7348021902b8e6791c425035d7a8f4353edd47cf8a477b3048a3792460a88a4b13ec1a75fa4fb8789c7d40ee0dd954995f0f57366311dccc649734b4a46922b5b21a185d5802af1d55895d7a146571d3d92fe1d904bbcc3b5adef7bfe513fe1149826cc9ca6c00b7b937ff9eb13f9e17abf0f5fec23ff008613e6bd5f87aff611ff00c30e65b00389d776bf7636977f37efb7ce1bbcd4adf0f5fec97fe18ae5dbb6519a2e539bd2cae9da92edeb292453543008e4a92cd59670af24d1257963a48f4da3052590af394b990bada00715cb8df8b2283299b37cc26965883597828c8228ea5b904b2a50548b94b358867511cf189259448afbd8154409e7355151afa0b1b9db4b459d5ce2d2dbbd7396c6e6fcad1f3e3b21a26be6766ada8248a6af039e59553357b9437dd8922d4b402c97ac91c52485e38da54974dd1a98eebe45d9b4797d3c9b2b83412499ae5d3bb1dd23cd357b899b5e99d98976322d499b7124a82a3c0018a59d8944d67398d9d36c96b32a53068d4aa6f8e5bd6ee5741a90b1189d14464e8b085504698bdbc17da350933c8b9d296e597a141238da506dcdcc16ecced1ef1040a60fd5f04d3ed125af2d8d77edd71a13159132bb1ba1a3926d291bbf63d72db25cf5b8200f330c1024ba0ba6c6e16fbd89bfcedbc59a8063761298563a0047ac1862e33f54b5f56b1f83261f70c5c67ea96bead63f064c55084f03faa55fab57fc15c3fe18381fd52afd5abfe0ae1ff08418c633801c21155389785d60b39864f39304798d8b19865938daa5e5b32796d858b7065372a5f32da111d59a39229006025e5b565146d66973345cddc2dcaa29c751ea5bb5141144f4c15b95a35950d7967ba969d8373248c224464991033d9ee2be0cab761f27b704762162098e51b86e52191d75ea922369b2442ae9d369075c5759f22cbf2de218ea55b0eef6b2b90cd5e6bb35c9abf925946add2692592249a2b560af31817116be9ed2579ff8b700acc2a45757504f2b2e65a6320b860e194b32b0e4cb7cc0ff00db29226abb2238db4bf9457fed67b5f8a3e1df207b2b6b37ce39de5fb797ba267b2c9984b3451902048f972d2ad1b7a61923d44bca9df159c9c4c7da3760198be699e49429acd04798734aa4c89624372bd7ba592195634954c96644de26d4bc73280795a621c5ea5c157464768e48e4564923914e8d1c91b8578dd4f42ae011fcc63c30c5a7ee8bc87cc661ef9f505834d0180207c3e1b000f48ecaecb970ea7a332e44e0f3dc02ebb116d328bef9493723ac6b6c614e14c309031978de2778f44271cd709d51158bb5d7a206867451e0827425947b86e42741e18e9626c737c3cfbae662fec535a0fe70c6c4ff00da900c5fd3dfba9a39587cf30fd4c72b7f48b9520f0d2cc98067135429e7a837b7e71bf89b3b915a3af5d41b33066d5b529146ba0e6c807880490abd3561a750343e1b593de8434d1da36ca8dd241346aa1d475610b26d64603e4aea3d83e6c7a3861b9966f58f1f4d6aa7cd1c2a19b4fa65ea7e818ea201d47fcffce98f769df672b29541d066b8bdc9d6dd45af6d2235d9a764183d5f0c2d56272b34e9ea583126e80ded6f3e6778f0d3cf51e01654eb1f2b9cc3dbb76b36d23d846d208f61d71c9f0ef02413d6592cc7ba7b3fb67901612461fd28d633e0811482ba03e3a9d750035c5295c92523a090cbcbf9d5e7e5a81f42bf4d3f88624b15796020f0450a3fea8d31eae4d2ab0946d7722fcecbe7eff48887607c2543515d894ca896b31259ee97300c2c58ebaf908e7384aeb833549db7cb58aed73d0cd0bead1c847f111d1fe8f9f19cdf89d9273057acf61d555e401d225456d7682ce4eacc0121475d31af35f4730aa47f5b5a78e4f9c4524732ebf413fcbafbf070a4badacd09fed6a8ff00280ffbf1f59109338806e81adb0be60a76e57b9de21d2fb32a0a9ed027e0134914fe27014d8805730009e9b47ab20cfa3b08c4029221db344e349236d35d187b8e84861d00f6e3daf1e1978821e55cab657a09c9a938fe3dca5a163fc477a95fa36fbc63a274d462c6a1154aba7c2c2fe9c88f6fc2d1a73b42e126e13c6a6e1d98b20b3231e6a76f71b18f3a478dc91b9921820825b56ecbf2ab5587469a5908240551e0aabe9bc8da2468198b2804e14aba1d716f7f468f66b1d89f36cee450cd0c8327a7b87fa30914562eb2ea7a99649e28c123e4a30fe302f70aa21573b2b7c205cfe9115c130f15f5191fe102e7f0b4559e31e02ccf2ab1056ce32f6a12da8a496b7f49af6526588a891775791c23a6f52c8da1dadb874ea76f0270158cdf32a393556314971d9ac4cba13528c3a35b9c6a0e922a7ece1ddd0cee8376bae96ebf4a444bb3871fda331b69afccf4db51fcca03fcb1c7fe8d0ca91f3bcf6c3282f5a965b5e26dbd563b72db965d0f882cd0a6ba7885f986243fb324a620aaa3c39735bcc1b44a3f6353a62892d47802e7b1d75048e7cb631df7797ee399355e1cbb265597475af6575cddad6e352d66634d0c93c5624dc24b06c42920224e60de54800aa8c512b39e4695c5963a46b1f349f16dbb5597febb13b47bc918fb81c4593acf0cb0bf84d14911ff000c88c87fd8c71f06b21b8b1d1a4d65018eb58a82d46474e557ba827471ff00a38d9587bb1798d52a4d6924f360a7d0c5ff0010d124e7a72dcdc213e47feda45d1ecd3f471dfbd452de679a49975bb11acb0d3a90c124758380516d3382d34a01d65489a3443aa873b771aebc75c157329ccace5398ecf2aae1244962e915baf21222b712b7a481c29478d8ea92861ab6bae3ed67a247f129c50afd28dc1802e499aa860d0db9b2b9d811fe8ef4466879bedd239ab00ade00cadaeedd1e3debf0c92f4e4220054696f2fd62eb13c169de9584b400a8b8200074fc6fe715bbbb7701459a7136514e74592b44f6730b1148372ca29463948547ca0279636dac086dba1075e9f6060c7c91ee95c462b71764e48d56d2dea1af800d62bf36327f8b7357d807f7c7b8e3eb92e3d705b7d912de77f5b9fca3d78742fd865dbcefeb98fe568560c18319c893478efe6291234923c71a22b3bbbb08d11146accccc42aaa81a92480002714b3bcaf66b5331a81a0ce2d7936550d8b11c50e5ef7e0ae9b0b2a5a785a37d238d0c75c6a27581816e72fed5acff006c4ffd1a352c22866b35639a73b74821332bf3747050333a4712b48ad1c6f2ab32ba2b29a25df2bbd34b7a7b595d39a2fd575dc2cf3c2fb9aecb1856950beba0af04dac6553fd23c258bb2681b1b884e49524f782e0e96ea630f8ad44a9321bbd5cc0e96ea79447ddd9b855e782cdb3ba3b093225368cb19249afc428f2227570b58835b306b7639524f1d1490c26bbb2ce971781bb398aadbca72eaea3d09df32b9205d1a44ab0b2a3b851a0df6a4ad1c48744489362682255c409dd3b2f8ea54f29b2c160a8925c762ba916ae6e85a3f475679a0737a18d5104a63bd0c5a17d775a1eed7c4b52d4d7a712f36fceb5e49a341aa54a1bacc74aac5602ec9ca3c7665b26196754b534cbbf6c68aba5d64be27c432e4a78645380ce7efbdaeab7e79010d6d86b717319fa3414f468a06b602dd2dfac582c67088f0bc6f811e10618b8cfd52d7d5ac7e0c987dc31719faa5afab58fc193154213c0fea957ead5ff0570ff860e07f54abf56aff0082b87fc21060c183084727da8f169a3975cba1416ad5679954f833a46446a74ea03310091d4027155789b2d196364ac4cf3d88eecd77319c00f24cb2d596bdfb764805cc2b25a86561182b0ac71102386be91db6e3ce1a4bb4ed53935096abcd0123f779b1b2ee1afb54b6a3e70315a725e2f9562caf3565266cb6796be6b1c6a58841cccbf3300315602ad845b848f4de1aac0072ea1b4a76812da655d04a9ee5699d9e5cc236bcc42a97be9cdb7d0464294d95edbd811f38f064f725b97731cd726b2972ac3975479638793629de9a19ae736b57b69a8f2c8eb2a046499a18e468d664f4f58a14ef8bc17038cbf3fa803477563af6a451d24592132d2b0fa1203100d7d7c4868935f4174b8bc45db65a6b32419556a96e1ab1c2f2cd2da78d6c34d0ad88a1a6618a7528d03aff004972f16f21023ed958555ed8f88236e0df4f48dee5f5f24aee53995c7ebc7b4b51821dbcfa346192b4db4b6c304a093a16c446bb0ec3f0baca34c3a6669a8eb2270e651d0952f6163902dc1f21d05a6bc278854d36272674bbdf32d80e6330047b8262a711848c2f08389408fd0c3d637c5e231c4e579bf93c399ca06ad0dab0e47bd8a47ca27fba7d11f46ec76711c717c5b544524ccdead7e3104edec866d0aa48dfdd65f16f1565ebef397c3b2b3194dcec7d6c6e47caf6f38e6eedd7039d8a6052e6c952c24cd57751af83626de51d0f08e4fc8ad1464eada192463fbd24877bff00913a7f2c6be35cd0c352c38f95cb289fe390f2c7fe2d70706e6a66a95d9be588f96ffe28c98cff00e1c79fb41a25e9cc146e28165d3dfca60e47d1a038f300fdb2d337cfaffabf08d9eeca9c2e5b0f1a7d9899607fed69eff9c7933da2a16865e9ed7859878ed86b0deec7e62c17c7e51fa31d7c8dd71ca702cc276b5781dc649de046f10208b69555f706662e7de4fcc71d429c7daf62ac257dddff0088ea7f21ed101ec57860e0b8009d30de6543198de4390fc4fbc733cd56cc66773a253a889b89d02b4e44cec7e6112b74f9fe8c6ce078f78b36b4205ab05e3d7c4c28a1233a7b068351f330c72f9afa66f420e86d6635abe9ef8caa391f46d56ffbb12598c01a2f451d15478018bbacfeaa52afde0a3d800df563f4889767f82b625c618b710541379731a4a0fa7d145bde399ed25f4aaadfc36aab8fa44a07fbf1d3698e6bb444d6b22fb5edd541fce40c7feca93fcb1d431eb8c6ceff00c3cbf56ff6c681fe92997fea091977ee45ff00d4d6fa4234eb8fa2dfa33a31e6ad7703432dfcd647ff0017974cbff85147f2c7ce927ae3e887e8ceb23cd786307ac198e69137bf5f2c7946a3d9aa48a7e823df89470c7c533d07e71a27843e29bfe5fce1a7f498f03cb6326a99842ad27ea8cc12dd908a5d96a491495ec3e8ba92b0874964241db12b780048803f47ff0019793f1472010d167396c8bb812759f2f616a323dfac0f3753f37bce3e9dddacaeac8e0347202acac0956561a32907a10c09041f1071f20fb09e1c6cbf8d72ccbb694f20e21ccaa22eed74ade4d69e35e875d3c9a48ba7b3403d87128a89369e93c79a9f42091f23135aaa7b554aa85df553fc24123e4df8c7d8ad71f157b6fece9a8e6f9f65322f46b362cd72de887a999319e375f6691bbc91161fbe9a7b003f6a71447f49e705d78a965b9e1d12cd3b90d2771a8e652b7ccdd137a7b5962991645d47a277e84063ad75d4e67ca2abb8f10f51ac7a6294a6a64655f887897d5751f3da2c47741e3b7cc786b25b5210f2bd189266e9ab4f587224274e8a4bc64e9ecc6eef53d91ae7590e6344b72d8c5cead27f6766ae962073e90dc0489a38d46aa48eba6399ee21c292d3e14c9e29d5d65780da747f4593caa479d50a9008db1c8ba862083a83d41c3b77c3ed14e57c3b9bdb4204be492415f5ebad9b5a558540d06a4b480e9aea74e98bff00ddd6326355d7de3e5ef77abed6739e189109124b9bd297a7a4540595e6f47a7a2a82404ff0f5f9b1f6bd71f2ff00f470761af6af2e72e87f57655149572f723a5abcebca9ec4475eb1d7884d187d1834b291bbd0656fa7c831614120c995976b926dd013a7d2317855399126d6b5cb103a026e3e9685e11349a0270bc3766f9bc70a3493489146a35692475445d7a0dcec428d4f4ea7ddef18c8c66238cb7c4d66c59b55ea352d2a7212516565937cb32730c65a2745836821082933b1d09541b58fce6ef63672fb99c55ab4465f665324b1661251a4f4decc8a52496b1612cb15a0b5e0b0b1b0dc5276dad29dcceb663bcde699cc14248f24b9465acf25ebf3f93db893323526796cce208e43cb9a28ddaceb3c12c7272155426e462699760bc30f6ef23c476b3ba415d88208604589278b51a092a1892d46e43297a36a0f459f99146319aeee14871640a5893b0ca2fa7fce51839ef32754cba554f09f13311a58721ef68b35c0fd80c76a66366432e5d5ad49225440cb52ee6024227b52f3a7b13dc8aac805585e7956295eaf323af0c42053633b00cb04b25ccd02a88ecb474e932f4dd4a81980940d142249767b5ca03709205864562b20023e162acf2d7c8ebd982a41e8d59df9cb14ac91c7a9cbe86acad35d96346590c3a9ad06f90e92b438b4196d248a248e35548e355444401551106d54503a6d5500003c00d31acf81b0faaafab998e5582a8732c997b5949b9623a9d353a9d4ed96d2da865551297dcc7b00c67060c6f38c741862e33f54b5f56b1f83261f70c5c67ea96bead63f064c2109e07f54abf56aff0082b87fc30703faa55fab57fc15c3fe1083060c1842304e216e37ecb6e456a5bd958864f28653732fb0e6049a54d89e575acaa4821b1c945592192168acb47131920612492cd58c04c61f15c269714a734d568190ee0fd08235047220c7a23b21cca6299c1934b9666297464ef95d2b6e94b33909a2217b73cbb685ad2b597decf61cd2794c7b9fcaabea485518857bc77621984b9cc31d15e756b91cd6eb56926582bd5b8a13cbcc7b869bed864b209defb8d9236a6ed6d9f6f751b31b4b9309258a98a5e5b7392ed149334d2495e8c45d0ab08e2782c5b60b2296961aca7747cc0d177ebc7cd3247992555cd326b13eb3011af2ef65864595979cb32c71661577105d0eb52e86207b39ab1b972303c5d570f25b2aaca9bde5dc29981bba62df159740c6f7096517cd689760d89cfa19ab552ad9d092b700eb6b1d0e97d6e3cf58a61c6bc017b2c748f30ab25532b1586425648266037148a742d1b49b753b1b63b0d74523ae39d618fa3b9d642b6e14ca73754b506695b9f46cac460e722aacc639220cfe4d9853568e50d1481650a664584a4d147f3fb8c383a6cbadd8a160ee96abece680556789943c33a83a0d248d86e0a08595644d754eb25a2ad9cd36651d6cb12ea25804806eae8740e84eb6be84126c48ea40eb1e02e3b6c6c9a5abb77b6ba91a66037b8ea3cb71e90c20e153d757564750c8c086561a820fb08f6e304631bb19904a9b88dc93a5aba9471707420ec4186be13e1b1515e2524c45cc91ebf297701b94fbf4d0687da3ae809203d038d6af82dda58d59dc854452ccc7c00035271eb3263ce9998fc47f18b3a5a5a6c3a97b95b2ca40773a05d4db5e407d23c9c3fc3d1d58da38f5daced20527a02da741f401e27df8f7038e622e3791b475a168c4dd55c6cdc54f50dc9243e847503761cb29e30ab39db1ca1641e314a0c728fa55f4ebf4138b99f4d504977173cc8b1f9db6f7889605c5fc3953fd8b0daa947268101b5bc8036bfb5e3c917072f97bdb63e8ed4644f6737672d9c8f785d7d2f95b9be9c743ae362a1f71c1cbfe5feec5bcd9af38ae6e4001e8225541875261ab30c80143bb4c63d598dc93ff003611cd712befb1420ffa592cb7f8618d827ffc8fff003a63a665c729c2d28b1627b7e318db5603ec31a1df2bafccf2f453ed0a71eae3ee304a50b48da173e8c49fc4c7ff00f2a3a9f9fa7b4e2f6749798f2e9906a07d4ea7e57b1f48fca9ed7718ff00a8b8ae79a539954896b6d8e5d09f43bc3f698b9bfa2fb8995573fcb4fcb8ee439927869b2e55485b4fa25a6469ec0753f2bad13e05e334b902c8340e3d1953daadefff000b7ca1eed4fbb412f7773ed59722e20a37a690252b4a72dcc589611a45336eab61f40401059080b9e8a8ee7d1d0b0cae0acd495864ccd2fa7bee3e7100c01da86bcc89ba120afbee3e7cbd63ec139c563cc3ba7a0e34a9c4b0aa98fc92d25c849e833011475eb5954dbd4c955e44909ea0c31900ef2458da93ea14aed61f294af5dc3f8b1ecc6c78dbb1b3114f6f7ddfe9f10c156a5d697c9ab5faf79e18f6aa596ae18082c6e46d629048439521c8d74f6e1a7b61ef6790648797773084ce00229d7d6dda3ab6d07c9e10ce9a1520194469a83e9743a4087f4a5e5e24eb9367095437a761bc90ba47ae9cd359676908035764525c283a75c79bcc442033017ea44783ce972c80ec013d481f9c5ddad5d005000000d00036803dc07b074f93885bbcff0077f6e258a8e5d3ccd0e58b6d6e66423d79d3c75918434d08d362cd34824797c51603b74665d257e13e29af76b416ab48934166249609a33b924491430653f383e07520ea0e841187a38f48f7862e18e1582a410d5ad0c70415d1228228942c71451a8544451d02e80123feff001c3ee0c0308400622ce3fcee24bf5d2d588aad4ab149996b288c0b12a2c9008f749d02d74979f205532992481834613d2e938fb89a58a358aa8df767d5605d9cc080322c962405a2022803abb6acbb89445d4be217ef099cd5af4e5ad9de6195da81d448b4aed2325cb52229758d7c9278cc45595395662acce8c49d0edd64f29b302292481e663ca6cc08a58903cced150bbcc779c7ced26cba8558ea50b3651cea8ab63309c3c7ca9adb2a8e4c65c2bc83d3939635924203c58eebb2eec36592182b55b1e45cbaeb0deb352031dcf27958ce2a0b52c92b0bd739a2f5b35e0aab48cc2a9372484cb1c0dd877090bb70346a14b34ed52199858156a73e58e4b1625e9bd2b80f4b9d2aa2da305c88f2daf57916d83f6cf4121928e5560f229997f586610569af723a34f6de25823912d5f776792496665af1c924b2bb5878deb4da338ab10ac99968690669ee7e23f04a5bdb31be82e74504137bd812003e582534c0ad5152f7276b6d6e400f4b131d97657d94d18f30ad4b2c82386b6592adbbf32fa724b60c6c6a5696762d24b6247905d98caeee2344d4696a322d6c78e77813842bd2ab143550ac617792c4b492c927a72cd331f49e799c9691dc9677249f0c74d8d9fc3983fec9a2590f30cc7d59998924b36e75d7c879011909af9daf6b4183060c4a63c60c31719faa5afab58fc1930fb862e33f54b5f56b1f83261084f03faa55fab57fc15c3fe18381fd52afd5abfe0ae1ff00084183060c210631bb19c61b08440bdb04669e6956fbf4ad72bc795cf213e8c13ad8925a05b5d008ecc93cd54b13af3e4ab19079808e4fb37ecf72af2c9a8663522794ccf365f2c8ec1331a924d2da7a76225d90589b2f9a79512bce930f2368186ba4eb1d8ce24e1b86dd79ab59412413c6d1ca8751e8b0d0e87a6d61e2aea772300c08201c57ae20e03bf0c5e477b2dfd7f4d64430d9805579c853be27b74ed495b6d88994013d379f7b8598455c931a69ec730babc3715fdb14327be4701674bb8bf87e175be84adad6f97519096eaf2fbb636b6c7f58f1f6cfdaa5bb7089ab65c8f432fcd2090dc13bb6608b96e61e4f994b0e58b536c90b411dcafa2de161a27768e12c2247a55df67b4cabfaed6789d668172fa35de484ab0323cb72dee2cbd0b2d6b1074f12bb7e48d316ef87aadac99e7b3fab2d50c8e59034e2ccb5da4a76a66eb763821b36da3cbe7723ca99da178acb3ce61e5cb6654afbde0fbbeae5b9d64d9ad458ff0056d9e20cacda8004d2bcd3da4e6b221fd9c95ad216dcba6a9296f14946c89a57cd9b8e838b4aeecbcb6ee74033212ad918dcd9d32f5d6e7a8cd2fe1dc47f654d35925ece8095d2e335adb74209f7fa4015e65750ca432b00cac0ea083d4107dd8c15c4bfde57bb4c9913c99865e9bf2591b7d8af1862f95c8fd59d13ab3506f13b75e4fa434d835c445e52a543865284021c11b483e041f0d0fb0eb8cc535449ac92b5148d9a5b6c7983cd587261cc7b8b820c769f0b715d363d4d9ee166a819d6fb1ea3aa9e47d8eb028c737da2102288b83c9162169fa13fb30493a8f02bbb4ddafb3f9e3a62b8c800f43a107a15235047ce3dbf462f69e6f75315c8da33d8f615fb5b0d9f421ca7788cb9872b8de3cd371042a9cd695163d3e5975dba69af4eba9e9fc3b8ff0074f861aa958a7994649884ab1b05612c604aa34d41075dea08f4948d0edf7f5c6d8b8269ab6f1561dde3a95d7afbf6fc9ff663c9c45974914a2e5752edb76d8847f5d18f92c9ec1247ec07e52eaba8c5fcaee58da53307e44d86bd34ebd6fbda38171afe8f98961386ceada5a8ef2721baaa5c12a2f7d4eb7b728c2f00841fb1b37201fc31d862bfc964074fa074c6c5e0347f58b16ec0fe19ac3ec3f3154d9a8f989d30eb9167d0d84df13861e057a8653ed5753a15607d9a01872dd8b79b59552ce466208f9fcf78e679fc4d8e4a534b36a6680342a5985bcad78f1bd568e3db5c46a5542c61b5d8ba0d00d17af4f1e988d27ec6ed589f9d7e7468f5f9309f48a83f2546d558d7e8d7e8d75d3afe3ce1a9e5557a5398661d342c55245f94013aeddc0f41a8f9891e38470ad29a9c524d9859e61d3afa45a28c13d068340ccc7da10f81d35f1c646966bc992664a98b9db4b5aefedfac79514f7a79066c898bde3696ca4ccbf97ebf9c7203b21b5527e6d19d029fdc949076ff000380ac9228f613b5bfba0e24faf599a2d93ac6ccca56455d4c641e8468403d474207fbf1cff13529adc31cd97da31b78a8dc447228d400415d0329ddd4e9d49047812be05e1eb3102f6ec34d2bf40371648d475d17ae9b891d7451a01a7b7a2a673ce92264d75ceba5ac43dc75fd63e564f7a89026ce98bde2696ca43dc753b79dff0038ec386b8a733cbc2a65f9d66d4a250a12186f4c6ba055da00af334b08006800080003400000636f1071b66f77d733bce2c20e9cb6bf2c30f5f7c559a18c9f66a549d3a6b86f64eb8d399e6d1c4017275660888aa5e495d8e8b1c68babc8ec4e8a141d4f418b49788d6bd911c927e71672b15c426da54b98c49e9bfcf786a1055a4aa22876ef246daf117908546776d1417611a2348e493a2866f053a7be1cf6164e62cb1b47a6bbf7aecd3c752dae83a7b0f5f9bd98bd1dc6bba5d8a8e73dce21115c96378b2ea4ec4b50af28fdac928f92b72cfc9217772a11b7706959527ecc3b9f70ccd3794cb90e52f3b3177634e2d8ee4966778c011b96624b6e462c4f5271294c07bd4569aed9f73cfdbda2672b85fbe96af3a63778756e7ededd6f114fe8ca82caf0e3f315d6ab66771f2ee602bad27e5b06407af29ac199a33fbc0ebf24ae2de918f352aaa8aa8aa155142aaa80aaaaa340aaa3a05006800e8063d2cd89828ca00e913e45c8a17a0b4602e1ab8878861a90cb62c4890c10c6f2cd348c1238a28d4b3c8eec40501412743a818f35de35ad1d77baf3c2b5638de592c19504091c60ef91a5ddb3600a46e2741a1fde1b714e338cea7e38922778a4adc295a612c304a1e39b886688feca79e3f45932c560248a197d29db95232295558b098d637498452b55d5bd946dd58f20a3993cbe66c05e3da5cb698d956242e02edb0718d1bd7b8765932fb942c59cbeb59b90ab433a4ab04e5cc41b9a9158558658db4496bc888cc92a09627f9dd5325b1985e9619642f64d8945db2d3090b3472491c852d36a8fcd314cd1cda944af14b676b257906246ff00e9b2c45067792652248a7ccf88f3a96e59eb1aa51164578e185e305e3431aa2cb3a2b32c7cbaf0abcb3a04923b0eec9a1a6c61976dd0926a95e855bb665b6c16320db535234a6baa23792ca48090411b4a5617e7c6b1dc525ac859aa8ccd6b84504924feee83a9dcedbf231869b412eba7a87f850ea6fa13d2dcfcfd2242e12ec0eb5ea95a3b51bbe5f02442382592c05bbb006491aa492b454e82b75ad4d2313c90a452d872f24b06248c8f85a3cc244a15628a2ca68c882f3448b1c3234277c796d558b68d04a11ee100a242a6bed77b0c61e8f2eecdb30cc7d737e5b4d81dd5e29c1cca707f726b303bc34974e8c2acb3cec090b341a36b31643c390d68a382bc51c304481228624e5c71a2f82a2a80aaa3dc00c41700e15c4311ac18a637e10ad9a5c81b29e44db4b8df9927527944a26ce445eee56bd4fe9e50ec87a6338c2e338df918d83060c18420c31719faa5afab58fc1930fb862e37f54b3f56b1f82d84213c0fea957ead5ff0570ff860e07f54abf56aff0082b87fc21060c183084183060c211823159fbec769b9fe4d4eadfc9c5414e294ae6d24b565b92d6aee5025b48629222d0427734fb5b98a0ab842a8e52cce3cd62a2b82aca195815652355652342ac0f4208e841d4118a48bc229df0f71cf1bd8892459f84333a562205498f338229e1953c758e3b4b2248ade1a68413aebd46235e21eca38badc10e5d356c9529c39a54b70cb05dbb2494e0ad6a3996bc7cfae1a64882c8b1963bc4451353cb0c7bae31e0d9f826592e548649f852c4a65b75230d2cdc3f2c87f6962bc63734996190ef9228bd2aecceca194ead3d70ff11c36618ec579639a19e3596392260e8f1b8d55d0a92195875046394b8e31ac7b08a954ab972a64b0c5a4cd2877f55600381b8d8ef620c66e9654a982eb70798bc7a2ca060caca0a9046d600ab2b0d0ab03a82a41d18104684f8e285f673dd532dce33cb93d449870bd4982f93bb95a9773342e6c2d365fda7ead818aab8520197541fb31b1675ed8b8b2ce6f74f0e65531842aabe797a23e953ace3514a07f65eb6baa8f6c3131909048d273e0ee1a828d682ad64486182358a28d468a8aa34007b49f6ee24ee624924924eb2a1c4aa787a8dde5b913aa1465507e04dc4c2393b8feef98525bf796326931f31eec902d624123303ba9b6e3a8da28176dbdd16fe4a5a7cb926ccb2bd598d75064bf413a91a7ef5baea06d1d0ca9e054f59310a6539bc73a092275753ed1ec3ed0478a91ed0402317efbcbf7899b2db79565997475e7ccf319d494b122a455e8c6473e79dd48110750e11f5d51629582b10aaf1f76add96f0967d79a3cbb35ab473b7d46fa13c245865560ab66b0630d86ea0b18d92660a3d22a74c6d4c1b1fab6a3953b1694d670c5672296f0a9b669a8a0d8137b38dec4e53ab46d6e16ed22ab082296a3fad9234b13e25f2563a103ee9f62368aa3b71956c74dda3f6399d64baf97d269eb03e8e6597abcf58afa5a19e20bceac76a1762e85003a0271c865d99c532ef8644917fb8daff98f11f41eb89ba159b2c4d92c1d0ecca430f98d8f91b1ea23a8706e29c33185fecb3416e687461fe53f88b886dcd7846195f9a37c330f09a0631c875fe323a49ff586bf3e3ccb93de4e91dc471ff4f5c6bfcda2743fcf4fe58e8b4c635c5e0ac9a00536206d9803f888c1637d9bf0e634e66d6d1a339dd85d49f52a45e393ceb31cc6bc66c3c95648e22a5e38e390314dca1cab12742012da9f763cfdb7465b2f629d4092263b7c36e8dd7e8d4a9ff6e3b59630ca55c065705181f02a46841fe58e4d63b3523689a3376a2a90bb5979c91ff0491b955902af8323f4006bd7a8c9d2cd576470143ab5eda2e61f85c4728769dd8f7eca992311e1ba52d2d3fbc4524b686f9b5d6d6f94797b0f631e5fb9ba0df2b2ebfc3a0ebf47463fcb5c5a4ec63b93e799d65753348b31a1516f2493455a7a92c922c1ce912291e48a6da4cd12a4a004042ba83d77e9b3b20ee219de6af08cc2b7ea7cabd032abcb13deb3002a4c50c359da3ac932b32b4b2ca244009543a827ea170fe47156862af046b14304690c31a8d1638a25091a28f62aa81a0f70c4b2930d0ef327d420bb9b8075b08e76a2c195e64da8ab962eed70a75b0fc2f141f21fd17f7dd8796f102ac7a7a4b4b2e5490fbc2cb62795549f00c226d3f8462c57631dcab22c9244b10d636efa11fd3f30636aca10a4168b72f2eb3302c3fa3ac7f2b4d483a62c2b1c637633b2a9e54afeed40f4112591492247f74817d008d2a98c336398ed03b51cbb2a80d8ccaed6a308fdfb132a6a7c36a2121a427c36a063af400e2bb66ddec330cd3f67c3396bb44c3439d67314b5292861a07ad51d56e5c6d0861be3890e9a330d3adb57e234d4128ceaa98a8839b1007f33d00d7a45eaa9636022c17695dade5d93d492de656e3a9047d0bc84866600111c48a1a49a53afa2912bb31e814e2afe7fc4d9cf167a005bc8787831dca5b919c66f1f8ed93612d9752906aad1ee16250483b46a07b786fbbced9ff5a66d6e4cf7360098acdf1b6bd56206e4a3562530538f70524c71bc9aebd4ea463cfdda3bc03e70b76b5daeb4b35cb6cc905da618e88a5db952c6cc499119548dfa68c50303a3296e7ce24ed22a2ae9a71c097c12f2879a7e2018900a21d6d7162e46848d01b18cb49a30ac3bddcec3f5310b7687d8d4193dea34aecb69b82ecdc69972f121f22a39ac8d11863ba49e749964ae8ef146d218a3b0fe92fa7abdd2ab0a2aed8c05501576a80aaaaa34555d3401401a00068069e034c78f8b785a0bd5a7ab6a249a09e3647461aab2b8d08f783ed0c0865201041008843b1ce2ab3945c5e1ccd26690156391de908d6e554ebe4933f406e538f453a759a251203d0e34c6218a5571151a34e98cd3a9d6c549243a6e6628fbe83499cca80dfbaf19044592c401a1e7d0f4fd2235ecbbb07e22c9efd8b75f2ec8ec97b56278a6bf72e9d2492ccb324dcb86b109b11f6c517a421732c9a97977097389fb44e3985259e5b5c259756850c92b94cd2ca471a2ee2ecf2c75c285009f6ebecc4c59ff0010c35a19679e58e28624679669182224683567773a050075d4e20ae09e0c9f8da58ae5c8a4838520984952aca1a39b3f9236d63b3662e8d1656b20e647137a5618464a2a8d06d9e0de25e24c767893244b492a47793321d07417241723616f3360231d3e448942fadf90890fb97f69bc459c53b198e6c2a791cf2e994c90569aa4b62ba1756b4f0c92ca5609fd13086224600b901583359a271e4ad5c2285550aaa00555002a80340a00e8000340074031ebc7502ed18883060c18ae1060c1830841862e37f54b3f56b1f82d87dc3171bfaa59fab58fc16c2109e07f54abf56aff0082b87fc30703faa55fab57fc15c3fe108318dd8ce118a842178309070ac53083060c18423cf66aab82ac032b02acac0156561a10c082082090411a10714d78cbb17bfc2af3dee1f8a4bd9217927bdc3ea759e9ee25a7b19316d3d11d646cbc9dac7511ea7d04ba58d7226b8c562785d2e254ed4d5681d1b707f107704722351ca2b47286eb1f2c78a73892b66b5388b862fc4b97e73612b661526de2a0cd9bd0863cc13e5506b4c45769f6466bd8d247d6291f1697b2eedfa0bb2bd1b314b96e6f00fe9195ddd12ca01a03240da94b55db4dc93c0cea50f82f418d7de6bb8cd6cda3b9632b9972bccae4622b5a29397e649d5b65eae3a7341eb1dd854588dc0605c840234ecbfbb6675c40d5bcf381aa264150e5f97cd4ac72ee5eb2cdd735f2cac5582450450242acc63794c8ed192e571abb14ecda9311a459331cf7b2fc2936de22a3e1598340f94786fa1b01a8d41bd9758c8d70343b8fd3a4403de4bbb45cb396f11711e763ff00b496c4432f8629cc90d5cb609238c7c9d158c91b7c927f667d2291bc8c12ed7621d996515e955b1472ea35ccf5a098c91558c392f1236bcc0bcd3a120fcb3a6386e31e19cff26865ab99d46e2bc8a45657b30471b66914077129772ff412eaaa8279f57f68da6a50b68d8edfb0ce3eca2c51860ca6c24b0d3852b884bb9b15962017956239c8b313a2e8a79ca0eaa7ab1d4e34f71a263b4942292b1582239cad2afdcf779155577b8b15b80e35cc4dfae429bba67ccbcc73def0c1db8779b3975c8b29a1974f9be6f62269a3a501551142ba8e65991b558e36008d4a10753a91d37c3dc39c1fc3bc4f72c53bf924f90f10578c4f2a452f934f2c5204516627afb2bdc8c3ec1bde195949f121989d19e719c5c31c5d9ae699ca4a68e6d56bc74f30481ec4755a00b1cf525e5a48f19660ada6c3b8043a1e843b760d9c3f10f15d8e23821961ca69e5bfaba9cb3c5cb6bb2c92732478d182b98515a4f940e9a45d3717dbf2929130cc3cd4530696a29d667da56630cd35ac7b90b7c86c4942b9736849368ad67b8982c750db0d2c3adc6b1cdf16fe8fccce125b2ccda1b49fbb0667018e4d46ba8f29aaac1c9e83d285413a92478e22ccff00bbbf1354244f92c9320febf2fb35ada37d1119239c69fde45ddecd71697f486f1fc997f0cccd0cef5e6b3669d58e78f723ab349cf628e9a48844559cea8436808d0ea710af67ddac4d4337c869e57c572711d4cca4682d51b5a4f3564e5f31a7364af35420d4ed936395561b1806db23c0313c5ab70b35f344a7fef2c191d6e25a86625e5d941dc0cc05c83ac4e6938f319c3d84b9552c545b46b3effc609f91f68822f0b10fac65d9a55f9e7cbad22ff26e51047ce3507dfedc3266dc615951c3bb292ac3478674eba787a512ff00b74c7d5eedaf8fe4caf27cc33189524969d59ac46926ee5bbc6bb82bec656dada1076b03a1f118ae5c07db3f165f82adbf377239ebdd8a29c347982c522c3205219a39e576dca8db8a753ecf1c5585f13bd753356ad2aacb56cbe2a854bb5b358674e9e71313dabe2ea3ba98b2dae3ee35fa726b7d227bc9bbfbf09c55a0439bac8eb0c48c2bd2cc2c9d42007d5e9cbedc7a27eff19230229d7cef30d3c3c8f24ccb427ddad886bedfa5f6a8f7e3a2972b5457e5471efd0ec1b140274e9af8789e9eff00a34e94728f79fe2cb99759cda29386e856ac6c8e458926e748f54b0923512cba076dba22ebe9965f93a83893e11da256e301fec94b2d421552664e2356b8502d2c937ca76f78d0f514ca8d7663adce83f9c5adb9deab3bb5a0cb384eea2f4226ce6e52cbd141f6b4304b7273a741e82927a83b71cde672f165f644bf9e50c92394e8b57258564b2fa75282ee62aec080189e4575234f945755c75dd817692d9c64f433178790d6a112bc67a05652e8e5777a4636642c8c7ab46ca7db8a4ffa4173f45e23a2be5d251b343266bb97c90c72cacf9935c944357643148c39cb069b9d420dcbb895255a3741c61c418f625330a56974ec82666655ce414b8b789986ad60481b6a23d1e9a54a96266a76fac5bce11eeb594d4956dcb14d995d5d34b99a599b31b208fde46b2f22c44924ee89109e9a93b574a95dac7793bb26679bc32f1245c35165d39ab4e9f904b62c5a745044f65a2ad61f952310aa17550875e58d0b4b697bac77858b3fa1cc65e4e615984398546051e19c0f9611ba88a5d0b02474219091cb6d396eddb82b3c19957bf95e5f91e690987972c17ab431d8866d414b06d32891a2450008d2452a370d8fba32b05c1eb66c9c627c9c7ed326852a1a7b2d94821bc266abcb01d459490058f84eb1733141960cadbcaff958c48fd8076b75f38cba09e2bb5afcb1a245666ad14b0af946c52ffb0b0b1cd187d750b227a5aeabd3c234ed93b17cc20cff002de20c8e3579d9d6966d5da44892c5171a89dddd802610ba1d0348cc21d0688416aec932f8784e2cc731cfefd44cc33bb11cf257a88ca9ba2122c55e9564065b0c0cb26a6288ee2c81b715dd8eea955e24e2223c9609b86b297d0b5fb688d9c598f51a2d4a4dbd69abc64912dbd641d76c6a462e30be1cad9f8b4e6c0d4352b0642f305a51575f1ae8173856272945dd430021367209604ddfa0df4dbd3ce1efb54ef0d5b2f75a90c6d7f35947f46caea6d7b0da9d03ccc7f675a15e9be5999140f921cf4c558e13cde5b599dae22e27bb11cbf2799ebe5d5a00c6a1cd7a2cc94107a579aae82012ed91ec58d59764712912776c5dd4b38c8e597cd081ed2e7559695f96d5ae65aa76d5f419a35ab1ab98a48649565552152608eb18215312d7765ee3506551d3b19a48333cce9c5cbaa5934a196a74e942b1f404faf592ecead625705bd0d493b7306ece16825cd901802e0299c3598548f184045a583f00f89882c493e1031b32af390dd3972fe71ce704f6277f8aa486f710c52d2c911d2c52c818859ed8521e09f3a2be087d175cbc37a27607d4ab2b5c6ad595155140555015554001540d0280340001a000000018f603831b870dc2e9b0da75a6a44088bb01f893b9279937262c9d99ce663060c1831958a20c183182708467061230ac210618b8dfd52cfd5ac7e0b61f70c5c6fea967ead63f05b0842781fd52afd5abfe0ae1ff000c1c0fea957ead5ff0570ff8420c230bc2308418c838c60c210bc184838561083060c184231a613ca5f761783084283e216ed5fba864f9bcc2d4b0cb4f305042667964ad4eea83a9eb244364c353bb6d84957c3a753accf801c50f2d5c156170770763ebe508a7f9cf65bc5b966bca929f15531fd45c1165d9aaaf8ed137a8d8751b80deb01274d4ebaebe4a3deb28542b066f4eff000fca46d0332a52c5558e9a811dd844949d0fb1b9a013aaf46f471728e3cf7f2d8e65649516546077248a19581e841560410474d08c6afc63b36c1312bb7766531d6f28e517fe0b14f5b283e71792eae6273bfac539ed5b80ab7134d924d5b30a73d3a17a3cc258e19167f2911ae9108e4899906dd5890ea41074257420ca7907673975695a7ad429c33382a6686b4114ada8d48dd1c6ac413d48d7a9d35d71b78bbb9070bdb7e71caa1ab3b12fe5197cb3e5d3863d750d4e4857c403a48acba81d06831ce1ee63341ff93b8a78829aea488accb53328935fdd5f2baad2951ee96593c74040000d7b88f65988b53a52d1d703290305575282ccc58e6284e6d7995f96d17695a972cc9a986cef6b5659386f388a08a59e5968c91c70c71b492b1976c7b5238d4bb1d189d154e8013d342452aec672ae1bac72b69b26e28ad7e034cc923c7756b1b68d1967285ca080cca58a9555dbd0a81a8c5da93b02e2f87510f1365d6d75f47cb72454934fef3d3b31213fe18906350eccb8ed7c2ff0a49f3c94f358ff000ece98fb84f06e3b85504ca00a8cacc5b324f7967550b623bb371617d63e4ca894ec1f5f717fce25707a7f3c7ce4ecebb8cd5cd62e248ae54b14af266f7065b9848b6a3535f7930ec859960b15da447deeb1b49a3e8b2210a45c36ecd38f1fc6ff000ac5f347533573fe5259d31b61eeff00c6136826e26cbea0d7a8a5922bc9a7f74dcb2f183fe289f18bc0382389f0749c94af291a619673676f0e46cdb64370c09041d088f49b552265b3026d7fafbc32f75bcc339f205a99dd5f27b549bc9d668da1105b8546c8a68d216f40ec501834480e81d557732a37e73c09569710d9e22bd98538626cba2a51c561a3468846e1da6696575450cc1bd0553ec3a9ea31daaf72f967ff00ca3c51c436d770262ad2d4cb63900fdd6f26aa928527c447347ee2483a1e9b84fb90f0c547128caa1b53ea1bca330926cc67dc0ea086b924a07524e8aa175f6633b4fd9856bd44ea99b532e577c0abac942cb6620b0533082b722fb69b0d348f26ac50a142dedb5ff94577cafb4bc88e6b6731c872dccb3acd6ca2c3626caa0b4d55c47a6bcd9dcc39702344066666236ed0db8ed69132deceb8b739d1ec4f578629378c758a6639b3aea4ed79d89a15dfc01d89338ebd75d36db2a797c70a84891511468a88a15540f001574000f7018f51189ee1dd9ee134aeb3672b4f7501434e6cf6034002e8a00fdd194db945abd4cc6161a0f2d221aeca3ba864d94cc6d450cb73302a15f32cce56bb7481a37a124ba2c00b0ddb6ba42a3afb86266c635c18d9692d5142a8000d80da2d20c634c67062b84183060c21060c18c1384202709c183084185e1230ac7d30830c5c6fea967ead63f05b0fb862e37f54b3f56b1f82d8f9084f03faa55fab57fc15c3fe18781fd52afd5abfe0c787ec210630463383084274c1a61583155e109d30ac18314c20c183061083060c18420c183061083060c18420d719dd8c60c21060c183084183060c2118c67060c21060c183084183060c21060c183084183060c210612461583084274c1a61583155e100183060c530830c5c67ea96bead63f064c3ee18b8cfd52d7d5ac7e0c98420e0cf54abf56aff00831e1f01c71dc21c5d53c92aff004aadead07f5d1ff66bfdec3bf9e353e2ab7dbc7f9b0843de0c3279e553e2ab7dbc5f9b079e553e2ab7dbc7f9b0843de0c3279e553e2ab7dbc7f9b079e553e2ab7dbc7f9b0843de0c3279e553e2ab7dbc7f9b079e553e2ab7dbc7f9b0843de0c3279e553e2ab7dbc7f9b079e553e2ab7dbc7f9b0843de0c3279e553e2ab7dbc7f9b079e553e2ab7dbc7f9b0843de0c3279e553e2ab7dbc5f9b079e553e2ab7dbc5f9b0843de0c3279e553e2ab7dbc5f9b19f3cea7c556fb78ff00361087ac1865f3cea7c556fb78ff00360f3cea7c556fb78ff361087ac1865f3cea7c556fb78ff360f3cea7c556fb78ff00361087ac1865f3cea7c556fb78ff00360f3cea7c556fb78ff361087ac1865f3cea7c556fb78ff360f3cea7c556fb78ff00361087ac1865f3cea7c556fb78ff003631e7954f8aadf6f17e6c210f7830c9e7954f8aadf6f17e6c1e7954f8aadf6f17e6c210f7830c9e7954f8aadf6f1fe6c1e7954f8aadf6f1fe6c210f7830c9e7954f8aadf6f1fe6c1e7954f8aadf6f1fe6c210f7830c9e7954f8aadf6f1fe6c1e7954f8aadf6f1fe6c210f7830c9e7954f8aadf6f1fe6c1e7954f8aadf6f1fe6c210f7830c9e7954f8aadf6f17e6c1e7954f8aadf6f1fe6c210f7862e32f54b5f56b1f83263679e353e2ab7db45f9b0cbc59c5d51aa58fe9507ab4ff00d6c7fd9b7f7b0847ffd9	1	Budi	12	Sidoarjo	Programmer	2342342	3
\.


--
-- Data for Name: tbljaminankendaraan; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbljaminankendaraan (idjaminankendaraan, jeniskendaraan, nopol, merk, nobpkb, nomesin, norangka, tglstnk, warna, besarcc, tahunbuat, pemilik, alamatpemilik, maxkredit, idpinjam) FROM stdin;
\.


--
-- Data for Name: tbljaminanshm; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbljaminanshm (idjaminanshm, noshm, atasnama, saksi1, saksi2, saksi3, hari, idpinjam) FROM stdin;
\.


--
-- Data for Name: tbljenis; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbljenis (jenissimpanan, ketjenis, bunga, kategori, besarsimpanan, trial825) FROM stdin;
POKOK 	001	0	POKOK	100000	T
SUKARELA	004	0.5	SUKARELA	0	T
OKE	OKE	0	WAJIB	10000	\N
20000	q12	0	POKOK	200000	\N
\.


--
-- Data for Name: tblkeuangan; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblkeuangan (idtransaksi, tgltransaksi, fakturtransaksi, masuk, keluar, saldo, keterangan, tambahan, notransaksi, trial825) FROM stdin;
\.


--
-- Data for Name: tblklasifikasi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblklasifikasi (idklasifikasi, klasifikasi, header, sub, keterangan, trial825) FROM stdin;
1	Kas	1	1	DEBET	T
2	Bank	1	2	DEBET	T
3	Piutang Dagang	1	3	DEBET	T
4	Persediaan	1	4	DEBET	T
5	Biaya Dibayar Dimuka	1	5	DEBET	T
6	Investasi Jangka Panjang	1	6	DEBET	T
7	Harta Tetap Berwujud	1	7	DEBET	T
8	Harta Tetap Tidak Berwujud	1	8	DEBET	T
9	Harta Lainya	1	9	DEBET	T
10	Hutang Lancar	2	1	KREDIT	T
11	Pendapatan Yang Diterima Dimuka	2	2	KREDIT	T
12	Hutang Jangka Panjang	2	3	KREDIT	T
13	Hutang Lain	2	4	KREDIT	T
14	Modal	3	1	KREDIT	T
15	Laba	3	2	KREDIT	T
16	Pendapatan Usaha	4	1	KREDIT	T
17	Pendapatan Lain	4	2	KREDIT	T
18	Biaya Produksi 	5	1	DEBET	T
19	Biaya Lain	5	2	DEBET	T
20	Biaya Operasional	6	1	DEBET	T
21	Biaya Non Operasional	6	2	DEBET	T
22	Pendapatan Luar Usaha	8	1	KREDIT	T
23	Pengeluaran Luar Usaha	9	1	DEBET	T
\.


--
-- Data for Name: tblkontak; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblkontak (idkontak, kodekontak, kelompok, namakontak, perusahaan, alamat, telp, email, web, saldokontak, trial825) FROM stdin;
\.


--
-- Data for Name: tbllaporan; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbllaporan (idakun, akun, nomer, deskripsi, kategori, pajak, saldo, flag, ketpajak, h1, h2, h3, nourut, trial825) FROM stdin;
\.


--
-- Data for Name: tblmenu; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblmenu (idmenu, dgroup, menucaption, menutag, menulevel, flag, trial825) FROM stdin;
5974	Administrator	Simpanan	10	0	t	\N
5984	Administrator	\t    Hitung Bunga Simpanan	20	0	t	\N
5985	Administrator	\t    Cetak Sampul Buku Simpanan	21	0	t	\N
5986	Administrator	\t    Cetak Buku Simpanan	22	0	t	\N
5987	Administrator	Pinjaman\t	23	0	t	\N
5988	Administrator	\t    Buat Pinjaman	24	0	t	\N
5990	Administrator	\t    Lihat Tagihan	26	0	t	\N
6011	Administrator	\t    Proses SHU	47	0	t	\N
5965	Administrator	Utilitas	1	0	t	\N
5966	Administrator	\t    Identitas	2	0	t	\N
5968	Administrator	\t    User	4	0	t	\N
5969	Administrator	Master	5	0	t	\N
5970	Administrator	\t    Anggota	6	0	t	\N
5971	Administrator	\t    Tahun Aktif	7	0	t	\N
5972	Administrator	\t    Jenis Simpanan	8	0	t	\N
5975	Administrator	\t    Buat Tagihan Simpanan	11	0	t	\N
5976	Administrator	\t    Lihat Tagihan	12	0	t	\N
5977	Administrator	\t    Pembayaran Simpanan Pokok Wajib	13	0	t	\N
6161	Oke	Utilitas	1	0	t	\N
6162	Oke	\t    Identitas	2	0	t	\N
6163	Oke	\t    Group	3	0	t	\N
6164	Oke	\t    User	4	0	t	\N
6165	Oke	Master	5	0	t	\N
5978	Administrator	\t    Pembayaran Kolektif Simpanan Pokok Wajib	14	0	t	\N
5979	Administrator	\t    Pengambulan Simpanan Pokok Wajib	15	0	t	\N
5980	Administrator	\t    Buat Rekening Simpanan Sukarela	16	0	t	\N
5981	Administrator	\t    Pembayaran Simpanan Sukarela	17	0	t	\N
5982	Administrator	\t    Pengambilan Simpanan Sukarela	18	0	t	\N
5983	Administrator	\t    Cetak Simpanan Sukarela	19	0	t	\N
5989	Administrator	\t    Buat Tagihan	25	0	t	\N
5991	Administrator	\t    Pembayaran Pinjaman Perorangan	27	0	t	\N
5992	Administrator	\t    Pembayaran Kolektif Pinjaman	28	0	t	\N
5993	Administrator	\t    Koreksi Pinjaman Nasabah	29	0	t	\N
5994	Administrator	\t    Koreksi Pembayaran Nasabah	30	0	t	\N
5995	Administrator	Laporan	31	0	t	\N
5996	Administrator	\t    Anggota	32	0	t	\N
5997	Administrator	\t    Peminjaman	33	0	t	\N
5998	Administrator	\t    Pembayaran Asuransi	34	0	t	\N
5999	Administrator	\t    Pembayaran Administrasi	35	0	t	\N
6000	Administrator	\t    Pembayaran Pinjaman	36	0	t	\N
6001	Administrator	\t    Histori Pembayaran Pinjaman	37	0	t	\N
6002	Administrator	\t    Saldo Piutang	38	0	t	\N
6003	Administrator	\t    Rekapitulasi Pendapatan	39	0	t	\N
6004	Administrator	\t    Rekapitulasi Saldo Piutang	40	0	t	\N
6005	Administrator	\t    Rekapitulasi Simpanan Pokok Wajib	41	0	t	\N
6006	Administrator	\t    Rekapitulasi Simpanan Sukarela	42	0	t	\N
6007	Administrator	\t    Lap. Transaksi Simpanan Sukarela	43	0	t	\N
6008	Administrator	\t    Lap. Simpanan Pokok Wajib	44	0	t	\N
6009	Administrator	\t    Lap. Tunggakan Simpanan	45	0	t	\N
6010	Administrator	\t    Lap. Pembayaran Bunga	46	0	t	\N
6012	Administrator	Keluar Aplikasi	48	0	t	\N
6013	Administrator	\t    Keluar	49	0	t	\N
6166	Oke	\t    Anggota	6	0	t	\N
6167	Oke	\t    Tahun Aktif	7	0	t	\N
6168	Oke	\t    Jenis Simpanan	8	0	t	\N
6169	Oke	\t    Buku Simpanan Sukarela	9	0	t	\N
6170	Oke	Simpanan	10	0	t	\N
6171	Oke	\t    Buat Tagihan Simpanan	11	0	t	\N
6172	Oke	\t    Lihat Tagihan	12	0	t	\N
6173	Oke	\t    Pembayaran Simpanan Pokok Wajib	13	0	t	\N
6174	Oke	\t    Pembayaran Kolektif Simpanan Pokok Wajib	14	0	t	\N
6175	Oke	\t    Pengambulan Simpanan Pokok Wajib	15	0	t	\N
6176	Oke	\t    Buat Rekening Simpanan Sukarela	16	0	t	\N
6177	Oke	\t    Pembayaran Simpanan Sukarela	17	0	t	\N
6178	Oke	\t    Pengambilan Simpanan Sukarela	18	0	t	\N
6179	Oke	\t    Cetak Simpanan Sukarela	19	0	t	\N
6180	Oke	\t    Hitung Bunga Simpanan	20	0	t	\N
6181	Oke	\t    Cetak Sampul Buku Simpanan	21	0	t	\N
5967	Administrator	\t    Group	3	0	t	\N
5973	Administrator	\t    Buku Simpanan Sukarela	9	0	t	\N
6182	Oke	\t    Cetak Buku Simpanan	22	0	t	\N
6183	Oke	Pinjaman\t	23	0	t	\N
6184	Oke	\t    Buat Pinjaman	24	0	t	\N
6185	Oke	\t    Buat Tagihan	25	0	t	\N
6186	Oke	\t    Lihat Tagihan	26	0	t	\N
6187	Oke	\t    Pembayaran Pinjaman Perorangan	27	0	t	\N
6188	Oke	\t    Pembayaran Kolektif Pinjaman	28	0	t	\N
6189	Oke	\t    Koreksi Pinjaman Nasabah	29	0	t	\N
6190	Oke	\t    Koreksi Pembayaran Nasabah	30	0	t	\N
6191	Oke	Laporan	31	0	t	\N
6192	Oke	\t    Anggota	32	0	t	\N
6193	Oke	\t    Peminjaman	33	0	t	\N
6194	Oke	\t    Pembayaran Asuransi	34	0	t	\N
6195	Oke	\t    Pembayaran Administrasi	35	0	t	\N
6196	Oke	\t    Pembayaran Pinjaman	36	0	t	\N
6197	Oke	\t    Histori Pembayaran Pinjaman	37	0	t	\N
6198	Oke	\t    Saldo Piutang	38	0	t	\N
6199	Oke	\t    Rekapitulasi Pendapatan	39	0	t	\N
6200	Oke	\t    Rekapitulasi Saldo Piutang	40	0	t	\N
6201	Oke	\t    Rekapitulasi Simpanan Pokok Wajib	41	0	t	\N
6202	Oke	\t    Rekapitulasi Simpanan Sukarela	42	0	t	\N
6203	Oke	\t    Lap. Transaksi Simpanan Sukarela	43	0	t	\N
6204	Oke	\t    Lap. Simpanan Pokok Wajib	44	0	t	\N
6205	Oke	\t    Lap. Tunggakan Simpanan	45	0	t	\N
6206	Oke	\t    Lap. Pembayaran Bunga	46	0	t	\N
6207	Oke	\t    Proses SHU	47	0	t	\N
6208	Oke	Keluar Aplikasi	48	0	t	\N
6209	Oke	\t    Keluar	49	0	t	\N
\.


--
-- Data for Name: tblneraca; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblneraca (idneraca, idakun, idperiode, debet, kredit, tanggal, ketneraca, fakturneraca, kelompok, akunasal, akuntujuan, useradd, tgl, bln, thn, urutan, flagneraca, saldoakun, penerima, terbilang, keterangan, ceknomer, idpenerima, bukti, notransaksi, trial825) FROM stdin;
\.


--
-- Data for Name: tblperiode; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblperiode (idperiode, periode, status, urutanperiode, trial825) FROM stdin;
20190430185059671	2020	AKTIF	0	T
20190430190129633	2022	TIDAK	0	T
2020032611532488	2021	TIDAK	\N	T
20200326120227115	2023	TIDAK	\N	T
20200413122226786	2024	TIDAK	\N	T
\.


--
-- Data for Name: tblpinjam; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblpinjam (idpinjam, idanggota, jenis, tglpinjam, besarpinjam, lamapinjam, persenbunga, administrasi, asuransi, angsuranpokok, angsuranbunga, jumlahangsuran, diterima, bayarpokok, bayarbunga, saldopinjam, statuspinjam, flagpinjam, addpinjam, flagpostingpinjam, flaggenerated, dendapersen) FROM stdin;
\.


--
-- Data for Name: tblrekap; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblrekap (idrekap, idpinjam, pokok, bunga, total, trial828) FROM stdin;
\.


--
-- Data for Name: tblrekapbunga; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblrekapbunga (idrekapsuk, idsukarela, rekapbunga, tglrekap, trial828) FROM stdin;
\.


--
-- Data for Name: tblrekapsimp; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblrekapsimp (idrekapsimp, idanggota, pokok, wajib, saldoawal, total, tglrekap, trial828) FROM stdin;
\.


--
-- Data for Name: tblrekapsukarela; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblrekapsukarela (idrekapsuk, idsukarela, saldorekap, tglrekap, trial828) FROM stdin;
\.


--
-- Data for Name: tblrekening; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblrekening (norek, idanggota, jenissimpanan, besar, tglrek, tglbayar, fbayar, tahun, ketsimp, ketkategori, faktur, flagrekening, tglambil, flagpostingrekening, trial828) FROM stdin;
\.


--
-- Data for Name: tblshu; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblshu (idshu, idanggota, tahunshu, shu, totalsimpanan, totalshu, trial828) FROM stdin;
\.


--
-- Data for Name: tblsisa; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblsisa (idsisa, idpinjam, pinjam, bayar, trial828) FROM stdin;
\.


--
-- Data for Name: tblsukarela; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblsukarela (idsukarela, idanggota, tglsukarela, flagsukarela, ketsukarela, bunga, kode, trial828) FROM stdin;
\.


--
-- Data for Name: tbltagihan; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbltagihan (idtagihan, idpinjam, tgltagihan, tglbayar, besarbayar, besarpokok, besarbunga, totalpokok, totalangsur, totalbunga, cicilanke, flagtagihan, kodetagihan, addtagihan, flagpostingtagihan, denda) FROM stdin;
\.


--
-- Data for Name: tbltahun; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbltahun (tahun, flagaktif) FROM stdin;
2020	NON AKTIF
2009	NON AKTIF
2011	NON AKTIF
2021	AKTIF
\.


--
-- Data for Name: tbltransaksi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbltransaksi (idtransaksi, fakturtransaksi, idsukarela, debet, kredit, tgltransaksi, kettransaksi, fb, nocetak, useradd, saldo, ketkode, flagpostingtransaksi, trial828) FROM stdin;
\.


--
-- Data for Name: tbluser; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbluser (iduser, duser, dpassword, namalengkap, dgroup, trial828) FROM stdin;
20210629183005	admin	admin123	Admin	Administrator	\N
20210731180744	oke	oke	Oke	Administrator	\N
\.


--
-- Name: tbljaminankendaraan_idjaminankendaraan_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbljaminankendaraan_idjaminankendaraan_seq', 1, false);


--
-- Name: tbljaminanshm_idjaminanshm_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbljaminanshm_idjaminanshm_seq', 1, false);


--
-- Name: tblkeuangan_idtransaksi_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblkeuangan_idtransaksi_seq', 1, false);


--
-- Name: tblmenu_idmenu_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblmenu_idmenu_seq', 6209, true);


--
-- Name: tblrekapbunga_idrekapsuk_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblrekapbunga_idrekapsuk_seq', 1, false);


--
-- Name: tblrekapsimp_idrekapsimp_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblrekapsimp_idrekapsimp_seq', 1, false);


--
-- Name: tblrekapsukarela_idrekapsuk_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblrekapsukarela_idrekapsuk_seq', 1, false);


--
-- Name: tblrekening_norek_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblrekening_norek_seq', 1, false);


--
-- Name: tblshu_idshu_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblshu_idshu_seq', 1, false);


--
-- Name: tblsisa_idsisa_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblsisa_idsisa_seq', 1, false);


--
-- Name: tblsukarela_idsukarela_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblsukarela_idsukarela_seq', 1, false);


--
-- Name: tbltransaksi_idtransaksi_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbltransaksi_idtransaksi_seq', 1, false);


--
-- Name: tbltransaksi_idtransaksi_seq1; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbltransaksi_idtransaksi_seq1', 5, false);


--
-- Name: tbltransaksi g; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbltransaksi
    ADD CONSTRAINT g PRIMARY KEY (idtransaksi);


--
-- Name: tblakun pk_tblakun; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblakun
    ADD CONSTRAINT pk_tblakun PRIMARY KEY (idakun);


--
-- Name: tblanggota pk_tblanggota; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblanggota
    ADD CONSTRAINT pk_tblanggota PRIMARY KEY (idanggota);


--
-- Name: tblbunga pk_tblbunga; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblbunga
    ADD CONSTRAINT pk_tblbunga PRIMARY KEY (idtransaksi);


--
-- Name: tblgroup pk_tblgroup; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblgroup
    ADD CONSTRAINT pk_tblgroup PRIMARY KEY (dgroup);


--
-- Name: tbljenis pk_tbljenis; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbljenis
    ADD CONSTRAINT pk_tbljenis PRIMARY KEY (jenissimpanan);


--
-- Name: tblkeuangan pk_tblkeuangan; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblkeuangan
    ADD CONSTRAINT pk_tblkeuangan PRIMARY KEY (idtransaksi);


--
-- Name: tblklasifikasi pk_tblklasifikasi; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblklasifikasi
    ADD CONSTRAINT pk_tblklasifikasi PRIMARY KEY (idklasifikasi);


--
-- Name: tblkontak pk_tblkontak; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblkontak
    ADD CONSTRAINT pk_tblkontak PRIMARY KEY (idkontak);


--
-- Name: tbllaporan pk_tbllaporan; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbllaporan
    ADD CONSTRAINT pk_tbllaporan PRIMARY KEY (idakun);


--
-- Name: tblmenu pk_tblmenu; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmenu
    ADD CONSTRAINT pk_tblmenu PRIMARY KEY (idmenu);


--
-- Name: tblneraca pk_tblneraca; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblneraca
    ADD CONSTRAINT pk_tblneraca PRIMARY KEY (idneraca);


--
-- Name: tblperiode pk_tblperiode; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblperiode
    ADD CONSTRAINT pk_tblperiode PRIMARY KEY (idperiode);


--
-- Name: tblpinjam pk_tblpinjam; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblpinjam
    ADD CONSTRAINT pk_tblpinjam PRIMARY KEY (idpinjam);


--
-- Name: tblrekap pk_tblrekap; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekap
    ADD CONSTRAINT pk_tblrekap PRIMARY KEY (idrekap);


--
-- Name: tblrekapbunga pk_tblrekapbunga; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapbunga
    ADD CONSTRAINT pk_tblrekapbunga PRIMARY KEY (idrekapsuk);


--
-- Name: tblrekapsimp pk_tblrekapsimp; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapsimp
    ADD CONSTRAINT pk_tblrekapsimp PRIMARY KEY (idrekapsimp);


--
-- Name: tblrekapsukarela pk_tblrekapsukarela; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapsukarela
    ADD CONSTRAINT pk_tblrekapsukarela PRIMARY KEY (idrekapsuk);


--
-- Name: tblrekening pk_tblrekening; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekening
    ADD CONSTRAINT pk_tblrekening PRIMARY KEY (norek);


--
-- Name: tblshu pk_tblshu; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblshu
    ADD CONSTRAINT pk_tblshu PRIMARY KEY (idshu);


--
-- Name: tblsisa pk_tblsisa; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblsisa
    ADD CONSTRAINT pk_tblsisa PRIMARY KEY (idsisa);


--
-- Name: tblsukarela pk_tblsukarela; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblsukarela
    ADD CONSTRAINT pk_tblsukarela PRIMARY KEY (idsukarela);


--
-- Name: tbltagihan pk_tbltagihan; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbltagihan
    ADD CONSTRAINT pk_tbltagihan PRIMARY KEY (idtagihan);


--
-- Name: tbltahun pk_tbltahun; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbltahun
    ADD CONSTRAINT pk_tbltahun PRIMARY KEY (tahun);


--
-- Name: tbluser pk_tbluser; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbluser
    ADD CONSTRAINT pk_tbluser PRIMARY KEY (iduser);


--
-- Name: tblidentitas tblidentitas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblidentitas
    ADD CONSTRAINT tblidentitas_pkey PRIMARY KEY (idkoperasi);


--
-- Name: tbljaminankendaraan tbljaminankendaraan_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbljaminankendaraan
    ADD CONSTRAINT tbljaminankendaraan_pk PRIMARY KEY (idjaminankendaraan);


--
-- Name: tbljaminanshm tbljaminanshm_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbljaminanshm
    ADD CONSTRAINT tbljaminanshm_pk PRIMARY KEY (idjaminanshm);


--
-- Name: _1cbb514c-b2a2-4a86-99b5-53aced8d87d7_; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "_1cbb514c-b2a2-4a86-99b5-53aced8d87d7_" ON public.tblneraca USING btree (idperiode);


--
-- Name: _4ab963fb-e73c-4461-915d-334a3683878d_; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "_4ab963fb-e73c-4461-915d-334a3683878d_" ON public.tbluser USING btree (dgroup);


--
-- Name: _4adc78b6-6e77-4ba2-a9ad-f29a2e06302e_; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "_4adc78b6-6e77-4ba2-a9ad-f29a2e06302e_" ON public.tblrekening USING btree (tahun);


--
-- Name: _66c055a2-2d7b-4ec8-9249-90a921d4e300_; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "_66c055a2-2d7b-4ec8-9249-90a921d4e300_" ON public.tblmenu USING btree (dgroup);


--
-- Name: _fdb3edb9-83fe-47fc-9d7a-368c0976edf8_; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "_fdb3edb9-83fe-47fc-9d7a-368c0976edf8_" ON public.tblneraca USING btree (idakun);


--
-- Name: fki_fkjenissimpanan; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_fkjenissimpanan ON public.tblrekening USING btree (jenissimpanan);


--
-- Name: idjenispeminjaman; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idjenispeminjaman ON public.tblpinjam USING btree (jenis);


--
-- Name: idmutasi; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idmutasi ON public.tblbunga USING btree (norek);


--
-- Name: idx_akun; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX idx_akun ON public.tblakun USING btree (akun);


--
-- Name: idx_idakun; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_idakun ON public.tblneraca USING btree (idakun);


--
-- Name: idx_idanggota; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_idanggota ON public.tblpinjam USING btree (idanggota);


--
-- Name: idx_idpenerima; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_idpenerima ON public.tblneraca USING btree (idpenerima);


--
-- Name: idx_idperiode; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_idperiode ON public.tblneraca USING btree (idperiode);


--
-- Name: idx_idpinjam; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_idpinjam ON public.tblrekap USING btree (idpinjam);


--
-- Name: idx_idsukarela; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_idsukarela ON public.tblrekapbunga USING btree (idsukarela);


--
-- Name: idx_ketjenis; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX idx_ketjenis ON public.tbljenis USING btree (ketjenis);


--
-- Name: idx_nomer; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX idx_nomer ON public.tblakun USING btree (nomer);


--
-- Name: idx_periode; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX idx_periode ON public.tblperiode USING btree (periode);


--
-- Name: tblanggotatblpinjam; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX tblanggotatblpinjam ON public.tblpinjam USING btree (idanggota);


--
-- Name: tblanggotatblshu; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX tblanggotatblshu ON public.tblshu USING btree (idanggota);


--
-- Name: tblpinjamtblrekap; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX tblpinjamtblrekap ON public.tblrekap USING btree (idpinjam);


--
-- Name: tblsukarelatblrekapbunga; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX tblsukarelatblrekapbunga ON public.tblrekapbunga USING btree (idsukarela);


--
-- Name: tblsukarelatbltransaksi; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX tblsukarelatbltransaksi ON public.tbltransaksi USING btree (idsukarela);


--
-- Name: tblpinjam hitungefektif_trigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER hitungefektif_trigger AFTER UPDATE OF saldopinjam ON public.tblpinjam FOR EACH ROW EXECUTE FUNCTION public.hitungefektif();


--
-- Name: tbltagihan setflagaktif_trigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER setflagaktif_trigger AFTER UPDATE OF besarbayar ON public.tbltagihan FOR EACH ROW EXECUTE FUNCTION public.setflagaktif();


--
-- Name: tblneraca _1cbb514c-b2a2-4a86-99b5-53aced8d87d7_; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblneraca
    ADD CONSTRAINT "_1cbb514c-b2a2-4a86-99b5-53aced8d87d7_" FOREIGN KEY (idperiode) REFERENCES public.tblperiode(idperiode) ON UPDATE CASCADE;


--
-- Name: tbluser _4ab963fb-e73c-4461-915d-334a3683878d_; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbluser
    ADD CONSTRAINT "_4ab963fb-e73c-4461-915d-334a3683878d_" FOREIGN KEY (dgroup) REFERENCES public.tblgroup(dgroup) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: tblrekening _4adc78b6-6e77-4ba2-a9ad-f29a2e06302e_; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekening
    ADD CONSTRAINT "_4adc78b6-6e77-4ba2-a9ad-f29a2e06302e_" FOREIGN KEY (tahun) REFERENCES public.tbltahun(tahun) ON UPDATE CASCADE;


--
-- Name: tblmenu _66c055a2-2d7b-4ec8-9249-90a921d4e300_; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmenu
    ADD CONSTRAINT "_66c055a2-2d7b-4ec8-9249-90a921d4e300_" FOREIGN KEY (dgroup) REFERENCES public.tblgroup(dgroup) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: tblneraca _fdb3edb9-83fe-47fc-9d7a-368c0976edf8_; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblneraca
    ADD CONSTRAINT "_fdb3edb9-83fe-47fc-9d7a-368c0976edf8_" FOREIGN KEY (idakun) REFERENCES public.tblakun(idakun) ON UPDATE CASCADE;


--
-- Name: tblrekening fkjenissimpanan; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekening
    ADD CONSTRAINT fkjenissimpanan FOREIGN KEY (jenissimpanan) REFERENCES public.tbljenis(jenissimpanan) ON UPDATE CASCADE ON DELETE RESTRICT NOT VALID;


--
-- Name: tblpinjam tblanggotatblpinjam; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblpinjam
    ADD CONSTRAINT tblanggotatblpinjam FOREIGN KEY (idanggota) REFERENCES public.tblanggota(idanggota) ON UPDATE CASCADE;


--
-- Name: tblrekapsimp tblanggotatblrekapsimp; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapsimp
    ADD CONSTRAINT tblanggotatblrekapsimp FOREIGN KEY (idanggota) REFERENCES public.tblanggota(idanggota) ON UPDATE CASCADE;


--
-- Name: tblrekening tblanggotatblrekening; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekening
    ADD CONSTRAINT tblanggotatblrekening FOREIGN KEY (idanggota) REFERENCES public.tblanggota(idanggota) ON UPDATE CASCADE;


--
-- Name: tblshu tblanggotatblshu; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblshu
    ADD CONSTRAINT tblanggotatblshu FOREIGN KEY (idanggota) REFERENCES public.tblanggota(idanggota) ON UPDATE CASCADE;


--
-- Name: tblsukarela tblanggotatblsukarela; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblsukarela
    ADD CONSTRAINT tblanggotatblsukarela FOREIGN KEY (idanggota) REFERENCES public.tblanggota(idanggota) ON UPDATE CASCADE;


--
-- Name: tbljaminankendaraan tbljaminankendaraan_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbljaminankendaraan
    ADD CONSTRAINT tbljaminankendaraan_fk FOREIGN KEY (idpinjam) REFERENCES public.tblpinjam(idpinjam) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- Name: tbljaminanshm tbljaminanshm_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbljaminanshm
    ADD CONSTRAINT tbljaminanshm_fk FOREIGN KEY (idpinjam) REFERENCES public.tblpinjam(idpinjam) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- Name: tblrekap tblpinjamtblrekap; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekap
    ADD CONSTRAINT tblpinjamtblrekap FOREIGN KEY (idpinjam) REFERENCES public.tblpinjam(idpinjam) ON UPDATE CASCADE;


--
-- Name: tblsisa tblpinjamtblsisa; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblsisa
    ADD CONSTRAINT tblpinjamtblsisa FOREIGN KEY (idpinjam) REFERENCES public.tblpinjam(idpinjam) ON UPDATE CASCADE;


--
-- Name: tbltagihan tblpinjamtbltagihan; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbltagihan
    ADD CONSTRAINT tblpinjamtbltagihan FOREIGN KEY (idpinjam) REFERENCES public.tblpinjam(idpinjam) ON UPDATE CASCADE;


--
-- Name: tblrekapbunga tblsukarelatblrekapbunga; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapbunga
    ADD CONSTRAINT tblsukarelatblrekapbunga FOREIGN KEY (idsukarela) REFERENCES public.tblsukarela(idsukarela) ON UPDATE CASCADE;


--
-- Name: tblrekapsukarela tblsukarelatblrekapsukarela; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblrekapsukarela
    ADD CONSTRAINT tblsukarelatblrekapsukarela FOREIGN KEY (idsukarela) REFERENCES public.tblsukarela(idsukarela) ON UPDATE CASCADE;


--
-- Name: tbltransaksi tblsukarelatbltransaksi; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbltransaksi
    ADD CONSTRAINT tblsukarelatbltransaksi FOREIGN KEY (idsukarela) REFERENCES public.tblsukarela(idsukarela) ON UPDATE CASCADE;


--
-- PostgreSQL database dump complete
--

