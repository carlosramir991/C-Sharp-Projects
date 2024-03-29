from django.db import models
from django.contrib.auth.models import AbstractBaseUser, BaseUserManager

class CustomUserManager(BaseUserManager):
    def create_user(self, email, first_name, last_name, password=None):
        if not email:
            raise ValueError('Users must enter an email')
        if not first_name:
            raise ValueError('Users must enter first name')
        if not last_name:
            raise ValueError('Users must enter last name')
        user = self.model(
                        email=self.normalize_email(email),
                        first_name=first_name,
                        last_name=last_name
                        )
        user.set_password(password)
        user.save(using=self._db)
        return user

    def create_superuser(self, email, first_name, last_name, password):
        user = self.create_user(
                        email=self.normalize_email(email),
                        password=password,
                        first_name=first_name,
                        last_name=last_name
                        )
        user.is_admin = True
        user.is_staff = True
        user.is_superuser = True
        user.save(using=self._db)

class CustomUser(AbstractBaseUser):
    username = None
    email = models.EmailField(verbose_name='email address', max_length=60, default='', unique=True)
    first_name = models.CharField(verbose_name='first name', max_length=50, default='', blank=False)
    last_name = models.CharField(verbose_name='last name', max_length=50, default='', blank=False)
    date_joined = models.DateTimeField(verbose_name='date joined', auto_now_add=True)
    last_login = models.DateTimeField(verbose_name='last login', auto_now_add=True)
    is_admin = models.BooleanField(default=False)
    is_active = models.BooleanField(default=True)
    is_staff = models.BooleanField(default=False)
    is_superuser = models.BooleanField(default=False)

    USERNAME_FIELD = 'email'
    REQUIRED_FIELDS = ['first_name', 'last_name']

    objects = CustomUserManager()

    def __str__(self):
        return self.email

    def has_perm(self, perm, obj=None):
        return self.is_admin

    def has_module_perms(self, app_label):
        return True


